using ConlluObject.Tokenization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConlluObject;
using System.Reflection;

namespace Client
{
	public partial class TreeViewForm : Form
	{
		public TreeViewForm(Sentence sentence)
		{
			InitializeComponent();

			var rootNode = new TreeNode(sentence.ToString());

			foreach (var token in sentence.Tokens)
			{
				var tokenNode = new TreeNode(token.ToString());

				var tokenType = token.GetType();

				foreach (var prop in tokenType.GetProperties())
				{
					var propValue = prop.GetValue(token);

					var atributesValues = getAtributesValues(propValue);

					var propNodeText = string.Format("{0}: {1}. {2}",
						prop.Name,
						propValue,
						string.IsNullOrEmpty(atributesValues)
							? string.Empty
							: string.Format(@"Детально -> {0}", atributesValues));

					var propNode = new TreeNode(propNodeText);

					if (propValue is Misc)
					{
						var miscType = propValue.GetType();

						foreach (var miscProp in miscType.GetProperties())
						{
							var miscNode = new TreeNode(string.Format("{0}: {1}", miscProp.Name, miscProp.GetValue(propValue)));
							propNode.Nodes.Add(miscNode);
						}
					}

					tokenNode.Nodes.Add(propNode);
				}
				rootNode.Nodes.Add(tokenNode);
			}
			rootNode.Expand();
			tree.Nodes.Add(rootNode);
		}

		private void TreeViewForm_Load(object sender, EventArgs e)
		{

		}

		private string getAtributesValues(object propValue)
		{
			if (propValue is SpeechCategories)
			{
				var description = ((SpeechCategories)propValue).GetAttributeValue<DescriptionAttribute, string>(t => t.Description);
				var fullName = ((SpeechCategories)propValue).GetAttributeValue<DescriptionAttribute, string>(t => t.FullName);

				return string.Format("Повна назва: {0}, Детально: {1}", fullName, description);
			}

			return string.Empty;
		}
	}
}
