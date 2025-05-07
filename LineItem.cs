using indice.Edi;
using indice.Edi.Serialization;

namespace EDI2XML;

// PO1*1*10*EA*15.00**BP*1234567890*VP*0987654321~
[EdiSegment, EdiPath("PO1")]
public class LineItem
{
	[EdiValue("X(10)", Path = "PO1/00")]
	public string LineNumber { get; set; }

	[EdiValue("X(10)", Path = "PO1/01")]
	public int Quantity { get; set; }

	[EdiValue("X(10)", Path = "PO1/02")]
	public string UnitOfMeasure { get; set; }

	[EdiValue("9(5)V99", Path = "PO1/03")]
	public decimal UnitPrice { get; set; }

	[EdiValue("X(10)", Path = "PO1/04")]
	public string Filler1 { get; set; }

	[EdiValue("X(10)", Path = "PO1/05")]
	public string Filler2 { get; set; }

	[EdiValue("X(2)", Path = "PO1/06")]
	public string ProductQualifier1 { get; set; }

	[EdiValue("X(30)", Path = "PO1/07")]
	public string ProductId1 { get; set; }

	[EdiValue("X(2)", Path = "PO1/08")]
	public string ProductQualifier2 { get; set; }

	[EdiValue("X(30)", Path = "PO1/09")]
	public string ProductId2 { get; set; }
}
