namespace Practica03_Proxy;

public class DocumentoProxy : IDocumento
{
    private DocumentoReal documentoReal;

    public string leer(string usuario)
    {
        if (usuario != "admin")
        {
            return "Acceso denegado";
        }

        if (documentoReal == null)
        {
            documentoReal = new DocumentoReal();
        }

        return documentoReal.leer(usuario);
    }
}