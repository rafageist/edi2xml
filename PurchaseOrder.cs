using indice.Edi;
using indice.Edi.Serialization;

namespace EDI2XML;

[EdiMessage]
public class PurchaseOrder
{
	[EdiSegment, EdiPath("BEG")]
	public BEGSegment BEG { get; set; }

	[EdiSegment, EdiPath("N1")]
	public N1Segment N1 { get; set; }

	[EdiSegment, EdiPath("PO1")]
	public List<LineItem> PO1 { get; set; } = new();
}
