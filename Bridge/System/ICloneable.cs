namespace System
{
    [Bridge.External]
    [Bridge.Convention(Target = Bridge.ConventionTarget.Member, Member = Bridge.ConventionMember.Method, Notation = Bridge.Notation.LowerCamelCase)]
    [Bridge.Reflectable]
    public interface ICloneable : Bridge.IBridgeClass
    {
        [Bridge.Template("Bridge.clone({this})")]
        object Clone();
    }
}