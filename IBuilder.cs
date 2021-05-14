namespace BuilderPattern
{
    public interface IBuilder
    {
         public void GetOperatingSystem(string os);
         public void GetGraphicsCards(string gpu);
         public void GetCPU(string cpu);
         public void GetRAM(int ramNum);
         public void GetStorage(string storage); 
    }
}