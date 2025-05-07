using indice.Edi;
using indice.Edi.Serialization;

namespace EDI2XML;

[EdiSegment, EdiPath("BEG")]
public class BEGSegment
{
	[EdiValue("X(2)", Path = "BEG/00")]
	public string TransactionSetPurposeCode { get; set; }

	[EdiValue("X(2)", Path = "BEG/01")]
	public string PurchaseOrderTypeCode { get; set; }

	[EdiValue("X(22)", Path = "BEG/02")]
	public string PurchaseOrderNumber { get; set; }

	[EdiValue("9(6)", Format = "yyyyMMdd", Path = "BEG/04")]
	public DateTime PurchaseOrderDate { get; set; }
}
