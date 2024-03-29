﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraDry.Analyzers.Test {
    public static class TestHelpers {

        public const string Stubs = @"
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Class)]
public class ApiControllerAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class RouteAttribute : Attribute
{
    public RouteAttribute() {}

    public RouteAttribute(string route) {}
}

[AttributeUsage(AttributeTargets.Method)]
public class HttpGetAttribute : Attribute
{
    public HttpGetAttribute() {}

    public HttpGetAttribute(string route) {}

    public string Name { get; set; }

    public string Template { get; set; }

    public int Order { get; set; }
}

[AttributeUsage(AttributeTargets.Method)]
public class HttpPatchAttribute : Attribute
{
    public HttpPatchAttribute() {}

    public HttpPatchAttribute(string route) {}

    public string Name { get; set; }

    public string Template { get; set; }

    public int Order { get; set; }
}

[AttributeUsage(AttributeTargets.Method)]
public class HttpDeleteAttribute : Attribute
{
    public HttpDeleteAttribute() {}

    public HttpDeleteAttribute(string route) {}

    public string Name { get; set; }

    public string Template { get; set; }

    public int Order { get; set; }
}

[AttributeUsage(AttributeTargets.Method)]
public class HttpPostAttribute : Attribute
{
    public HttpPostAttribute() {}

    public HttpPostAttribute(string route) {}

    public string Name { get; set; }

    public string Template { get; set; }

    public int Order { get; set; }
}

[AttributeUsage(AttributeTargets.Method)]
public class HttpPutAttribute : Attribute
{
    public HttpPutAttribute() {}

    public HttpPutAttribute(string route) {}

    public string Name { get; set; }

    public string Template { get; set; }

    public int Order { get; set; }
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AllowAnonymousAttribute : Attribute
{
    public AllowAnonymousAttribute() {}
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute
{
    public AuthorizeAttribute() {}

    public AuthorizeAttribute(string policy) {}

    public string Policy { get; set; }

    public string Roles { get; set; }
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ConsumesAttribute : Attribute
{
    public ConsumesAttribute(string contentType, params string[] otherTypes) {}

    public int ConsumesActionConstraintOrder { get; set; }
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ProducesAttribute : Attribute
{
    public ProducesAttribute(string contentType, params string[] otherTypes) {}

    public ProducesAttribute(Type type) {}

    public int StatusCode { get; set; }
}

public class ControllerBase {}

public class Controller : ControllerBase {}

public static class MediaTypeNames {
    public static class Application {
        public const string Json = ""application/json"";
        public const string Octet = ""application/octet-stream"";
        public const string Pdf = ""application/pdf"";
        public const string Rtf = ""application/rtf"";
        public const string Soap = ""application/soap+xml"";
        public const string Xml = ""application/xml"";
        public const string Zip = ""application/zip"";
    }
    public static class Image {
        public const string Gif = ""image/gif"";
        public const string Jpeg = ""image/jpeg"";
        public const string Tiff = ""image/tiff"";
    }
    public static class Text {
        public const string Html = ""text/html"";
        public const string Plain = ""text/plain"";
        public const string RichText = ""text/richtext"";
        public const string Xml = ""text/xml"";
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class JsonIgnoreAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Property)]
public class KeyAttribute : Attribute {}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class SkipStatusCodePagesAttribute : Attribute {}

[AttributeUsage(AttributeTargets.Class)]
public class ApiExceptionStatusCodesAttribute : Attribute {}

// Stubs from ExtraDry.Core
public class UriReference {}
public class WebIdReference {}
public class UuidReference {}

[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Property)]
public class JsonConverterAttribute : Attribute {
    public JsonConverterAttribute() {}
    public JsonConverterAttribute(Type type) {}
}

[AttributeUsage(AttributeTargets.Class)]
public class ApiExplorerSettingsAttribute : Attribute {
    public ApiExplorerSettingsAttribute() {}
    public bool IgnoreApi { get; set; }
}

public class JsonConverter {}

public class JsonConverter<T> {}

public class JsonStringEnumConverter {}

[AttributeUsage(AttributeTargets.Method)]
public class ValidateAntiForgeryTokenAttribute : Attribute {}

";

    }
}
