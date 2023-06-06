using PostSharp.Aspects;

namespace AspectOriented.Attribute.Logging
{
    //there using PostSharp
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
            args.ReturnValue = "Hesaplama işlemine başlanıyor...";
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);
            args.ReturnValue = "Hesaplama işlemi bitti...";
        }
    }
}
