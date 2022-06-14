using System;

public class Metodos
{
	public Metodos()
	{
        public void Verifica()
        {
            if (tb_visor.Text == "")
            {
                tb_visor.Text = "0";
            }
            else
            {
                valor_segundo = Convert.ToDouble(tb_visor.Text);
            }
        }
    }

}
