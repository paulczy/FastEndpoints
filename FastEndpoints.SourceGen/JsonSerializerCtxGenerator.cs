using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace FastEndpoints.SourceGen
{
    [Generator]
    public class JsonSerializerCtxGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext ctx)
        {
            ctx.AddSource("SerializerCtx", SourceText.From(@"
using System.Text.Json.Serialization;

namespace FastEndpoints;

[
    JsonSerializable(typeof(Admin.Login.Request)),
    JsonSerializable(typeof(Admin.Login.Response)),
    JsonSerializable(typeof(Customers.Create.Request)),
    JsonSerializable(typeof(Customers.List.Recent.Response))
]
public partial class GeneratedSerializerCtx : JsonSerializerContext { }", Encoding.UTF8));
        }

        public void Initialize(GeneratorInitializationContext ctx)
        {

        }

        public class SyntaxReceiver : ISyntaxContextReceiver
        {
            public void OnVisitSyntaxNode(GeneratorSyntaxContext ctx)
            {

            }
        }
    }
}