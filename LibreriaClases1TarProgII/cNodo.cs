namespace LibreriaClases1TarProgII
{
    public class cNodo
    {
        //atributos
        public object aElemento;
        public cNodo aSgteNodo;

        //metodos
        //constructores
        public cNodo()
        {
            aElemento = null;
            aSgteNodo = null;
        }

        public cNodo(object pEelemento, cNodo pSgteNodo)
        {
            aElemento = pEelemento;
            aSgteNodo = pSgteNodo;
        }

        //set y get
        public object GetElemento()
        {
            return aElemento;
        }

        
        public void SetElemento(object value)
        {
            aElemento = value;
        }

        
        public cNodo GetSgteNodo()
        {
            return aSgteNodo;
        }

        
        public void SetSgteNodo(cNodo value)
        {
            aSgteNodo = value;
        }
        //otros metodos



    }
}