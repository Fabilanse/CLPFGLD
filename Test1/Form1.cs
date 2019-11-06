using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConlluObject;
using Ufal.Parsito;
using IronPython.Hosting;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ConlluObjectTokenSentenceDebug;
using ConlluObject.Tokenization;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            var engine = Python.CreateEngine();
            var paths = engine.GetSearchPaths();
        
            paths.Add(@"C:\Program Files\IronPython 2.7\Lib");
            paths.Add(@"C:\Program Files\IronPython 2.7\Lib\site-packages");
            //paths.Add(@"C:\Python27\Lib"); // or you can add the CPython libs instead
            engine.SetSearchPaths(paths);

            var a = engine.ExecuteFile(@"C:\Users\User\source\repos\IronPythonApplication1\IronPythonApplication1\IronPythonApplication1.py");

            var sentences = a.GetVariable("sentences");

			var pronouns = new List<Sentence>();
			var errorSentenses = new List<Sentence>();
			foreach (var tokens in sentences)
			{
				var sentence = new Sentence();

				foreach (var t in tokens)
				{
					var item = new Token(t);

					sentence.Tokens.Add(item);

					if (item.Deprel == DependencyRelationsTypes.Null)
					{
						MessageBox.Show(item.Lemma);
						errorSentenses.Add(sentence);
					}
				}
				pronouns.Add(sentence);
			}

			// MessageBox.Show(string.Join(Environment.NewLine, pronouns));



			textBox2.Text = string.Empty;

			#region Parsito

			//Console.Error.Write("Loading parser: ");
			//Parser parser = Parser.load(args[0]);
			//if (parser == null)
			//{
			//    Console.Error.WriteLine("Cannot load parser from file '{0}'", args[0]);
			//    return 1;
			//}
			//Console.Error.WriteLine("done");

			//TreeInputFormat conlluInput = TreeInputFormat.newInputFormat("conllu");
			//TreeOutputFormat conlluOutput = TreeOutputFormat.newOutputFormat("conllu");

			//Tree tree = new Tree();
			//for (bool not_eof = true; not_eof;)
			//{
			//    string line;
			//    StringBuilder textBuilder = new StringBuilder();

			//    // Read block
			//    while ((not_eof = (line = Console.In.ReadLine()) != null) && line.Length > 0)
			//    {
			//        textBuilder.Append(line).Append('\n');
			//    }
			//    if (not_eof) textBuilder.Append('\n');

			//    // Tokenize and tag
			//    string text = textBuilder.ToString();
			//    conlluInput.setText(text);
			//    while (conlluInput.nextTree(tree))
			//    {
			//        parser.parse(tree);

			//        string output = conlluOutput.writeTree(tree, conlluInput);
			//        Console.Write(output);
			//    }
			//    if (conlluInput.lastError().Length > 0)
			//    {
			//        Console.Error.WriteLine("Cannot read input CoNLL-U: {0}", conlluInput.lastError());
			//        return 1;
			//    }
			//}


			#endregion

			return;

            #region UdpAnal
            //            //if (args.Length < 3)
            //            //{
            //            //    Console.Error.WriteLine("Usage: RunUDPipe input_format(tokenize|conllu|horizontal|vertical) output_format(conllu) model");
            //            //    return 1;
            //            //}
            //            var fileName = @"C:\Users\User\source\repos\Test1\ukrainian-iu-ud-2.3-181115.udpipe";
            //            Console.Error.Write("Loading model: ");
            //            Model model = Model.load(fileName);
            //            if (model == null)
            //            {
            //                Console.Error.WriteLine("Cannot load model from file '{0}'", fileName);
            //            }
            //            Console.Error.WriteLine("done");

            //            #region MyRegion
            //            var input = string.Empty;
            //            #endregion

            //            var outStr = string.Empty;

            //            Pipeline pipeline = new Pipeline(model, input, Pipeline.DEFAULT, Pipeline.DEFAULT, outStr);
            //            ProcessingError error = new ProcessingError();

            //            // Read whole input
            //            StringBuilder textBuilder = new StringBuilder();
            //            string line;
            //            while ((line = Console.In.ReadLine()) != null)
            //                textBuilder.Append(line).Append('\n');

            //            // Process data
            //            string text = @"# doc_title = Сад Гетсиманський
            //# newdoc id = 028g
            //# newpar id = 02tb
            //# sent_id = 02to
            //# text = Дідусь, той що атестував, посміхнувся й спитав:
            //# translit = Diduś, toj ščo atestuvav, posmichnuvśа j spytav:
            //1	Дідусь	дідусь	NOUN	Ncmsny	Animacy=Anim|Case=Nom|Gender=Masc|Number=Sing	7	nsubj	7:nsubj|9:nsubj	Id=02tp|LTranslit=diduś|SpaceAfter=No|Translit=Diduś
            //2	,	,	PUNCT	U	_	3	punct	3:punct	Id=02tq|LTranslit=,|Translit=,
            //3	той	той	DET	Pd--m-sna	Case=Nom|Gender=Masc|Number=Sing|PronType=Dem	7	dislocated	5:nsubj:rel|7:dislocated|9:dislocated	Id=02tr|LTranslit=toj|Translit=toj
            //4	що	що	SCONJ	Css	_	5	mark	5:mark	Id=02ts|LTranslit=ščo|Translit=ščo
            //5	атестував	атестувати	VERB	Vmpis-sm	Aspect=Imp|Gender=Masc|Mood=Ind|Number=Sing|Tense=Past|VerbForm=Fin	3	acl:relcl	3:acl:relcl	Id=02tt|LTranslit=atestuvaty|SpaceAfter=No|Translit=atestuvav
            //6	,	,	PUNCT	U	_	5	punct	5:punct	Id=02tu|LTranslit=,|Translit=,
            //7	посміхнувся	посміхнутися	VERB	Vmeis-sm	Aspect=Perf|Gender=Masc|Mood=Ind|Number=Sing|Tense=Past|VerbForm=Fin	0	root	0:root	Id=02tv|LTranslit=posmichnutyśа|Translit=posmichnuvśа
            //8	й	й	CCONJ	Ccs	_	9	cc	9:cc	Id=02tw|LTranslit=j|Translit=j
            //9	спитав	спитати	VERB	Vmeis-sm	Aspect=Perf|Gender=Masc|Mood=Ind|Number=Sing|Tense=Past|VerbForm=Fin	7	conj	0:root|7:conj	Id=02tx|LTranslit=spytaty|SpaceAfter=No|Translit=spytav
            //10	:	:	PUNCT	U	_	7	punct	7:punct	Id=02ty|LTranslit=:|Translit=:";
            //            string processed = pipeline.process(text, error);


            //            if (error.occurred())
            //            {
            //                MessageBox.Show("An error occurred in RunUDPipe: {0}", error.message);
        //}
        #endregion
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void Button1_Click(object sender, EventArgs e)
		{

			//var engine = Python.CreateEngine();
			//var paths = engine.GetSearchPaths();

			//paths.Add(@"C:\Program Files\IronPython 2.7\Lib");
			//paths.Add(@"C:\Program Files\IronPython 2.7\Lib\site-packages");
			////paths.Add(@"C:\Python27\Lib"); // or you can add the CPython libs instead
			//engine.SetSearchPaths(paths);

			//var a = engine.ExecuteFile(@"C:\Users\User\source\repos\IronPythonApplication1\IronPythonApplication1\IronPythonApplication1.py");

			//var sentences = a.GetVariable("sentences");

			//var tokensList = new List<TokenSentenceDebug>();
			//foreach (var tokens in sentences)
			//{
			//	foreach (var t in tokens)
			//	{
			//		var item = new TokenSentenceDebug(t);
			//		tokensList.Add(item);
			//	}
			//}

			var fileName = @"C:\Users\User\Documents\CLPFGLD\Test1\Сериализованнный тестовый корпус";

			//FileStream stream = File.Create(fileName);
			var formatter = new BinaryFormatter();
			//Console.WriteLine("Serializing vector");
			//formatter.Serialize(stream, tokensList);
			//stream.Close();

			// Restore from file
			FileStream stream2 = File.OpenRead(fileName);
			Console.WriteLine("Deserializing vector");
			var v = (List<TokenSentenceDebug>)formatter.Deserialize(stream2);
			stream2.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Button2_Click(object sender, EventArgs e)
		{

		}

		//public PyConverter NewMyDictConverter()
		//{
		//    using (Py.GIL())
		//    {
		//        var converter = new PyConverter();
		//        converter.AddListType();
		//        converter.Add(new StringType());
		//        converter.Add(new Int64Type());
		//        converter.Add(new Int32Type());
		//        converter.Add(new FloatType());
		//        converter.Add(new DoubleType());
		//        converter.AddDictType<string, object>();
		//        return converter;
		//    }
		//}
	}
}
