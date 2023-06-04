using PostSharp.Aspects;

namespace AspectOriented.Attribute.Logging
{
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
            Console.WriteLine("Hesaplama işlemine başlanıyor...");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);
            Console.WriteLine("Hesaplama işlemi tamamlandı.");
        }
    }
}
