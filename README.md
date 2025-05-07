# EDI to XML .NET Demo Project

A .NET-based project to convert X12 EDI messages into XML format for easier integration, validation, or transformation. This tool is intended for developers working with legacy EDI systems who need to bridge them with modern XML workflows.

## Features

- Parses EDI X12 messages (e.g. 850, 856, 810, etc.)
- Converts EDI segments into structured XML
- Simple, extensible architecture built with .NET
- Ready for integration into APIs or data pipelines

## Example

### Input (X12)

```edi
ISA*00*          *00*          *ZZ*SENDERID       *ZZ*RECEIVERID     *210101*1234*U*00401*000000001*0*P*>~
GS*PO*SENDERID*RECEIVERID*20210101*1234*1*X*004010~
ST*850*0001~
BEG*00*SA*123456789**20210101~
N1*ST*Rafa*92*12345~
PO1*1*10*EA*15.00**BP*1234567890*VP*0987654321~
PO1*1*80*EA*25.00**BP*1234557890*VP*0987654321~
CTT*1~
SE*8*0001~
GE*1*1~
IEA*1*000000001~
```

### Output (XML)

```xml
<?xml version="1.0" encoding="utf-8"?>
<PurchaseOrder xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <BEG>
    <TransactionSetPurposeCode>00</TransactionSetPurposeCode>
    <PurchaseOrderTypeCode>SA</PurchaseOrderTypeCode>
    <PurchaseOrderNumber>123456789</PurchaseOrderNumber>
    <PurchaseOrderDate>0001-01-01T00:00:00</PurchaseOrderDate>
  </BEG>
  <N1>
    <EntityIdentifierCode>ST</EntityIdentifierCode>
    <Name>Rafa</Name>
    <IdentificationCodeQualifier>92</IdentificationCodeQualifier>
    <IdentificationCode>12345</IdentificationCode>
  </N1>
  <PO1>
    <LineItem>
      <LineNumber>1</LineNumber>
      <Quantity>10</Quantity>
      <UnitOfMeasure>EA</UnitOfMeasure>
      <UnitPrice>15.00</UnitPrice>
      <Filler2>BP</Filler2>
      <ProductQualifier1>1234567890</ProductQualifier1>
      <ProductId1>VP</ProductId1>
      <ProductQualifier2>0987654321</ProductQualifier2>
    </LineItem>
    <LineItem>
      <LineNumber>1</LineNumber>
      <Quantity>80</Quantity>
      <UnitOfMeasure>EA</UnitOfMeasure>
      <UnitPrice>25.00</UnitPrice>
      <Filler2>BP</Filler2>
      <ProductQualifier1>1234557890</ProductQualifier1>
      <ProductId1>VP</ProductId1>
      <ProductQualifier2>0987654321</ProductQualifier2>
    </LineItem>
  </PO1>
</PurchaseOrder>
```
