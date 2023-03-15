using Antlr4.Runtime;
//if (a == "fsd" ) {}
while (true)
{
    string input = Console.ReadLine();
    if (input == "")
        break;

    var cs = CharStreams.fromString(input);
    SSJLexer lexer = new SSJLexer(cs);
    CommonTokenStream tokens = new CommonTokenStream(lexer);
    SSJParser parser = new SSJParser(tokens);
    var tree = parser.program();
    var visitor = new ProyectoGrupo1.SSJTranscriber();
    Console.WriteLine(visitor.Visit(tree));

}


