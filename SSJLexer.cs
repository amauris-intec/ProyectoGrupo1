//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\ama\source\repos\ProyectoGrupo1\SSJ.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class SSJLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, PARENTESIS_DERECHO=11, VARIABLE=12, PARENTESIS_IZQUIERDO=13, 
		COMILLAS=14, LLAVE_IZ=15, LLAVE_DR=16, IGUAL=17, OPERADOR_RELACIONAL=18, 
		OPERADOR_ARITMETICO=19, NUMERO=20, STRING=21, TEXTO=22, WS=23;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "PARENTESIS_DERECHO", "VARIABLE", "PARENTESIS_IZQUIERDO", "COMILLAS", 
		"LLAVE_IZ", "LLAVE_DR", "IGUAL", "OPERADOR_RELACIONAL", "OPERADOR_ARITMETICO", 
		"NUMERO", "STRING", "TEXTO", "WS"
	};


	public SSJLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SSJLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'show'", "'if'", "'&&'", "'||'", "'for'", "';'", "'while'", "'else'", 
		"'int'", "'string'", "')'", null, "'('", "'\"'", "'{'", "'}'", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, "PARENTESIS_DERECHO", 
		"VARIABLE", "PARENTESIS_IZQUIERDO", "COMILLAS", "LLAVE_IZ", "LLAVE_DR", 
		"IGUAL", "OPERADOR_RELACIONAL", "OPERADOR_ARITMETICO", "NUMERO", "STRING", 
		"TEXTO", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SSJ.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SSJLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x19', '\x98', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x5', 
		'\r', '\x61', '\n', '\r', '\x3', '\r', '\x3', '\r', '\x5', '\r', '\x65', 
		'\n', '\r', '\x5', '\r', 'g', '\n', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x5', '\x13', '|', '\n', '\x13', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x15', '\x6', '\x15', '\x81', '\n', '\x15', 
		'\r', '\x15', '\xE', '\x15', '\x82', '\x3', '\x16', '\x3', '\x16', '\a', 
		'\x16', '\x87', '\n', '\x16', '\f', '\x16', '\xE', '\x16', '\x8A', '\v', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\a', 
		'\x17', '\x90', '\n', '\x17', '\f', '\x17', '\xE', '\x17', '\x93', '\v', 
		'\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x2', 
		'\x2', '\x19', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', 
		'\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', 
		'\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', 
		'!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', 
		'\x17', '-', '\x18', '/', '\x19', '\x3', '\x2', '\t', '\x4', '\x2', '>', 
		'>', '@', '@', '\x6', '\x2', '\'', '\'', ',', '-', '/', '/', '\x31', '\x31', 
		'\x3', '\x2', '\x32', ';', '\x3', '\x2', '$', '$', '\x5', '\x2', '\x43', 
		'\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', 
		'\\', '\x61', '\x61', '\x63', '|', '\x5', '\x2', '\v', '\f', '\xF', '\xF', 
		'\"', '\"', '\x2', '\xA2', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '\x36', '\x3', '\x2', '\x2', '\x2', '\a', '\x39', '\x3', '\x2', 
		'\x2', '\x2', '\t', '<', '\x3', '\x2', '\x2', '\x2', '\v', '?', '\x3', 
		'\x2', '\x2', '\x2', '\r', '\x43', '\x3', '\x2', '\x2', '\x2', '\xF', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x11', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x13', 'P', '\x3', '\x2', '\x2', '\x2', '\x15', 'T', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '[', '\x3', '\x2', '\x2', '\x2', '\x19', '\x66', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', 'h', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'j', '\x3', '\x2', '\x2', '\x2', '\x1F', 'l', '\x3', '\x2', '\x2', '\x2', 
		'!', 'n', '\x3', '\x2', '\x2', '\x2', '#', 'p', '\x3', '\x2', '\x2', '\x2', 
		'%', '{', '\x3', '\x2', '\x2', '\x2', '\'', '}', '\x3', '\x2', '\x2', 
		'\x2', ')', '\x80', '\x3', '\x2', '\x2', '\x2', '+', '\x84', '\x3', '\x2', 
		'\x2', '\x2', '-', '\x8D', '\x3', '\x2', '\x2', '\x2', '/', '\x94', '\x3', 
		'\x2', '\x2', '\x2', '\x31', '\x32', '\a', 'u', '\x2', '\x2', '\x32', 
		'\x33', '\a', 'j', '\x2', '\x2', '\x33', '\x34', '\a', 'q', '\x2', '\x2', 
		'\x34', '\x35', '\a', 'y', '\x2', '\x2', '\x35', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '\x36', '\x37', '\a', 'k', '\x2', '\x2', '\x37', '\x38', 
		'\a', 'h', '\x2', '\x2', '\x38', '\x6', '\x3', '\x2', '\x2', '\x2', '\x39', 
		':', '\a', '(', '\x2', '\x2', ':', ';', '\a', '(', '\x2', '\x2', ';', 
		'\b', '\x3', '\x2', '\x2', '\x2', '<', '=', '\a', '~', '\x2', '\x2', '=', 
		'>', '\a', '~', '\x2', '\x2', '>', '\n', '\x3', '\x2', '\x2', '\x2', '?', 
		'@', '\a', 'h', '\x2', '\x2', '@', '\x41', '\a', 'q', '\x2', '\x2', '\x41', 
		'\x42', '\a', 't', '\x2', '\x2', '\x42', '\f', '\x3', '\x2', '\x2', '\x2', 
		'\x43', '\x44', '\a', '=', '\x2', '\x2', '\x44', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '\x45', '\x46', '\a', 'y', '\x2', '\x2', '\x46', 'G', '\a', 
		'j', '\x2', '\x2', 'G', 'H', '\a', 'k', '\x2', '\x2', 'H', 'I', '\a', 
		'n', '\x2', '\x2', 'I', 'J', '\a', 'g', '\x2', '\x2', 'J', '\x10', '\x3', 
		'\x2', '\x2', '\x2', 'K', 'L', '\a', 'g', '\x2', '\x2', 'L', 'M', '\a', 
		'n', '\x2', '\x2', 'M', 'N', '\a', 'u', '\x2', '\x2', 'N', 'O', '\a', 
		'g', '\x2', '\x2', 'O', '\x12', '\x3', '\x2', '\x2', '\x2', 'P', 'Q', 
		'\a', 'k', '\x2', '\x2', 'Q', 'R', '\a', 'p', '\x2', '\x2', 'R', 'S', 
		'\a', 'v', '\x2', '\x2', 'S', '\x14', '\x3', '\x2', '\x2', '\x2', 'T', 
		'U', '\a', 'u', '\x2', '\x2', 'U', 'V', '\a', 'v', '\x2', '\x2', 'V', 
		'W', '\a', 't', '\x2', '\x2', 'W', 'X', '\a', 'k', '\x2', '\x2', 'X', 
		'Y', '\a', 'p', '\x2', '\x2', 'Y', 'Z', '\a', 'i', '\x2', '\x2', 'Z', 
		'\x16', '\x3', '\x2', '\x2', '\x2', '[', '\\', '\a', '+', '\x2', '\x2', 
		'\\', '\x18', '\x3', '\x2', '\x2', '\x2', ']', '\x61', '\x5', ')', '\x15', 
		'\x2', '^', '\x61', '\x5', '-', '\x17', '\x2', '_', '\x61', '\x5', '+', 
		'\x16', '\x2', '`', ']', '\x3', '\x2', '\x2', '\x2', '`', '^', '\x3', 
		'\x2', '\x2', '\x2', '`', '_', '\x3', '\x2', '\x2', '\x2', '\x61', 'g', 
		'\x3', '\x2', '\x2', '\x2', '\x62', '\x65', '\x5', ')', '\x15', '\x2', 
		'\x63', '\x65', '\x5', '+', '\x16', '\x2', '\x64', '\x62', '\x3', '\x2', 
		'\x2', '\x2', '\x64', '\x63', '\x3', '\x2', '\x2', '\x2', '\x65', 'g', 
		'\x3', '\x2', '\x2', '\x2', '\x66', '`', '\x3', '\x2', '\x2', '\x2', '\x66', 
		'\x64', '\x3', '\x2', '\x2', '\x2', 'g', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', 'h', 'i', '\a', '*', '\x2', '\x2', 'i', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', 'j', 'k', '\a', '$', '\x2', '\x2', 'k', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', 'l', 'm', '\a', '}', '\x2', '\x2', 'm', ' ', '\x3', '\x2', '\x2', 
		'\x2', 'n', 'o', '\a', '\x7F', '\x2', '\x2', 'o', '\"', '\x3', '\x2', 
		'\x2', '\x2', 'p', 'q', '\a', '?', '\x2', '\x2', 'q', '$', '\x3', '\x2', 
		'\x2', '\x2', 'r', 's', '\a', '?', '\x2', '\x2', 's', '|', '\a', '?', 
		'\x2', '\x2', 't', 'u', '\a', '#', '\x2', '\x2', 'u', '|', '\a', '?', 
		'\x2', '\x2', 'v', '|', '\t', '\x2', '\x2', '\x2', 'w', 'x', '\a', '@', 
		'\x2', '\x2', 'x', '|', '\a', '?', '\x2', '\x2', 'y', 'z', '\a', '>', 
		'\x2', '\x2', 'z', '|', '\a', '?', '\x2', '\x2', '{', 'r', '\x3', '\x2', 
		'\x2', '\x2', '{', 't', '\x3', '\x2', '\x2', '\x2', '{', 'v', '\x3', '\x2', 
		'\x2', '\x2', '{', 'w', '\x3', '\x2', '\x2', '\x2', '{', 'y', '\x3', '\x2', 
		'\x2', '\x2', '|', '&', '\x3', '\x2', '\x2', '\x2', '}', '~', '\t', '\x3', 
		'\x2', '\x2', '~', '(', '\x3', '\x2', '\x2', '\x2', '\x7F', '\x81', '\t', 
		'\x4', '\x2', '\x2', '\x80', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x81', 
		'\x82', '\x3', '\x2', '\x2', '\x2', '\x82', '\x80', '\x3', '\x2', '\x2', 
		'\x2', '\x82', '\x83', '\x3', '\x2', '\x2', '\x2', '\x83', '*', '\x3', 
		'\x2', '\x2', '\x2', '\x84', '\x88', '\a', '$', '\x2', '\x2', '\x85', 
		'\x87', '\n', '\x5', '\x2', '\x2', '\x86', '\x85', '\x3', '\x2', '\x2', 
		'\x2', '\x87', '\x8A', '\x3', '\x2', '\x2', '\x2', '\x88', '\x86', '\x3', 
		'\x2', '\x2', '\x2', '\x88', '\x89', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'\x8B', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x88', '\x3', '\x2', '\x2', 
		'\x2', '\x8B', '\x8C', '\a', '$', '\x2', '\x2', '\x8C', ',', '\x3', '\x2', 
		'\x2', '\x2', '\x8D', '\x91', '\t', '\x6', '\x2', '\x2', '\x8E', '\x90', 
		'\t', '\a', '\x2', '\x2', '\x8F', '\x8E', '\x3', '\x2', '\x2', '\x2', 
		'\x90', '\x93', '\x3', '\x2', '\x2', '\x2', '\x91', '\x8F', '\x3', '\x2', 
		'\x2', '\x2', '\x91', '\x92', '\x3', '\x2', '\x2', '\x2', '\x92', '.', 
		'\x3', '\x2', '\x2', '\x2', '\x93', '\x91', '\x3', '\x2', '\x2', '\x2', 
		'\x94', '\x95', '\t', '\b', '\x2', '\x2', '\x95', '\x96', '\x3', '\x2', 
		'\x2', '\x2', '\x96', '\x97', '\b', '\x18', '\x2', '\x2', '\x97', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\n', '\x2', '`', '\x64', '\x66', '{', '\x82', 
		'\x88', '\x91', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}