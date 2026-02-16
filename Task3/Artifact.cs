namespace LabPolymorphism;

abstract class Artifact
{
    public int Id{ get; set; }

   public  Artifact(int id)
    {
        Id=id;
    }

    public abstract void Identify();

}