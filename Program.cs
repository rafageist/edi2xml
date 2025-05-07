using System.Xml.Serialization;
using indice.Edi;

namespace EDI2XML;

class Program
{
	static void Main(string[] args)
	{
		var ediContent = File.ReadAllText("edi.txt");
		var grammar = EdiGrammar.NewX12();
		var ediStream = new StringReader(ediContent);

		var serializer = new EdiSerializer();
		var purchaseOrder = serializer.Deserialize<PurchaseOrder>(ediStream, grammar);

		Console.WriteLine("Deserializado correctamente.");
		foreach (var item in purchaseOrder.PO1)
		{
			Console.WriteLine($"Línea {item.LineNumber}, Qty: {item.Quantity}, UOM: {item.UnitOfMeasure}, Precio: {item.UnitPrice}");
		}

		using var xmlStream = new StreamWriter("purchaseOrder.xml");
		var xmlSerializer = new XmlSerializer(typeof(PurchaseOrder));
		xmlSerializer.Serialize(xmlStream, purchaseOrder);

		Console.WriteLine("success");
	}
}
