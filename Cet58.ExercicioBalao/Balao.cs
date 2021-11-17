namespace Cet58.ExercicioBalao
{
    public class Balao
    {
        #region Atributos

        private string _cor;

        private int _direcao;

        private int _altura;

        private bool _estado;

        #endregion

        #region Propriedades

        public string Cor
        {
            get
            {
                return _cor;
            }
            set
            {
                _cor = value;
            }
        }
        public int Direcao
        {
            get
            {
                return _direcao;
            }
            set
            {
                _direcao = value;
            }
        }
        public int Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                _altura = value;
            }
        }
        public bool Estado
        {
            get
            {
                return _estado;
            }
        }
        #endregion

        #region Métodos
        public Balao()
        {
            _cor = "";
            _direcao = 0;
            _altura = 0;
            _estado = false;
        }
        public void Start()
        {
            _estado = true;
        }
        public void Stop()
        {
            _estado = false;
        }

        #endregion
    }
}
