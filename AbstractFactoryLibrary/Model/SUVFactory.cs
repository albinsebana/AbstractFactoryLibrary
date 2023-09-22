namespace AbstractFactoryLibrary.Model
{
    public class SUVFactory : IAutoFactory
    {
        

        public IAudi CreateAudi()
        {
            return new AudiSUV();
        }

        public IBmw CreateBmw()
        {
            return new BmwSUV();
        }

        public ITesla CreateTesla()
        {
            return new TeslaSUV();
        }
    }
}