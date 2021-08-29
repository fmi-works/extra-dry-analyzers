﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Linq;

namespace Blazor.ExtraDry.Analyzers {

    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class ApiControllerPublicMethodShouldHaveVerb : DryDiagnosticNodeAnalyzer {

        public ApiControllerPublicMethodShouldHaveVerb() : base(
            SyntaxKind.MethodDeclaration,
            1006,
            DryAnalyzerCategory.Usage,
            DiagnosticSeverity.Warning,
            "Public methods of ApiController Classes should have a REST verb (e.g. HttpGet)",
            "Method '{0}' on class '{1}' should have a HttpVerb attribute",
            "API Controllers should be exclusively used as a public API interface, public methods that are not exposed might indicate functionality that should be refactored into a Service class."
            )
        { }

        public override void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            var method = (MethodDeclarationSyntax)context.Node;
            if(method == null) {
                context.ReportDiagnostic(Diagnostic.Create(Rule, context.Node.GetLocation(), "method is null", ""));
                return;
            }
            var _class = method.FirstAncestorOrSelf<ClassDeclarationSyntax>(e => e is ClassDeclarationSyntax);
            if(_class == null) {
                context.ReportDiagnostic(Diagnostic.Create(Rule, method.Identifier.GetLocation(), "_class is null", ""));
                return;
            }
            var isPublic = HasVisibility(method, Visibility.Public);
            var hasApiAttribute = HasAttribute(context, _class, "ApiController", out var _);
            var hasVerbAttribute = HasAnyAttribute(context, method, out var _, "HttpGet", "HttpPut", "HttpPost", "HttpDelete", "HttpPatch");
            if(hasApiAttribute && isPublic && !hasVerbAttribute) {
                context.ReportDiagnostic(Diagnostic.Create(Rule, method.Identifier.GetLocation(), method.Identifier.ValueText, _class.Identifier.ValueText));
            }
        }

    }
}