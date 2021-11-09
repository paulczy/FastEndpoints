using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace FastEndpoints.SourceGen;

[Generator]
public class JsonSerializerCtxGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext ctx)
    {
        //Log.FlushLogs(ctx);
        ctx.AddSource("logs.g.cs", SourceText.From("//this is a text", Encoding.UTF8));
    }

    public void Initialize(GeneratorInitializationContext ctx)
    {
        //Log.Print("hello from init...");
    }

    public class SyntaxReceiver : ISyntaxContextReceiver
    {
        public void OnVisitSyntaxNode(GeneratorSyntaxContext ctx)
        {

        }
    }
}

//#if DEBUG
public static class Log
{
    public static List<string> Logs { get; } = new();

    public static void Print(string msg) => Logs.Add("//\t" + msg);

    public static void FlushLogs(GeneratorExecutionContext context)
    {
        context.AddSource("logs.g.cs", SourceText.From(string.Join("\n", Logs), Encoding.UTF8));
    }
}
//#endif