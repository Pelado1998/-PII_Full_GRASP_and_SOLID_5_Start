
namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Se desea utilizar el patrón de diseño DIP ya que mediante este dieño se crea
    /// flexibilidad y resistencia, ya que se pueden realizar cambios a diferentes clases,
    /// pero sin modificar la clase ConsolePrinter, siempre y cuando esta ultima reciba un objeto
    /// de tipo IPrint.
    /// </summary>
    public interface IPrint
    {
        string GetTextToPrint();
    }
}