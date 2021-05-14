namespace BuilderPattern
{
    public class Director
    {
        public IBuilder _builder;

        public Director(IBuilder builder) {
            _builder = builder;
        }

        public void BuildGamingComputer(){
            _builder.GetOperatingSystem("sdf");
            _builder.GetGraphicsCards("sdf");
            _builder.GetCPU("sdfsf");
            _builder.GetRAM(0);
            _builder.GetStorage("sdf");
        }
        public void BuildDevelopmentComputer(){
            _builder.GetOperatingSystem("sdf");
            _builder.GetGraphicsCards("sdf");
            _builder.GetCPU("sdfsf");
            _builder.GetRAM(0);
            _builder.GetStorage("sdf");
        }
        public void BuildCustomComputer(string os, string gpu, string cpu, int ram, string storage){
            _builder.GetOperatingSystem(os);
            _builder.GetGraphicsCards(gpu);
            _builder.GetCPU(cpu);
            _builder.GetRAM(ram);
            _builder.GetStorage(storage);
        }
    }
}