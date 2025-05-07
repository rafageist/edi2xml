using indice.Edi;
using indice.Edi.Serialization;

namespace EDI2XML;

[EdiSegment, EdiPath("N1")]
public class N1Segment
{
	[EdiValue("X(2)", Path = "N1/00")]
	public string EntityIdentifierCode { get; set; }

	[EdiValue("X(60)", Path = "N1/01")]
	public string Name { get; set; }

	[EdiValue("X(2)", Path = "N1/02")]
	public string IdentificationCodeQualifier { get; set; }

	[EdiValue("X(80)", Path = "N1/03")]
	public string IdentificationCode { get; set; }
}
