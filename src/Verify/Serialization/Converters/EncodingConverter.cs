class EncodingConverter :
    WriteOnlyJsonConverter<Encoding>
{
    public override void Write(VerifyJsonWriter writer, Encoding value) =>
        writer.WriteValue(value.EncodingName);
}