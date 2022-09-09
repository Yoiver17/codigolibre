  //clase coche
  class Coche
    {
        //atributos
        private int _id;
        private String _marca;
        private String _modelo;
        private int _km;
        private double _precio;
        
        //constructor
        public Coche(int id, string marca, string modelo, int km, double precio)
        {
            this._id = id;
            this._marca = marca;
            this._modelo = modelo;
            this._km = km;
            this._precio = precio;
        }
        //metodos
        public int id { get => _id; set => _id = value; }
        public string marca { get => _marca; set => _marca = value; }
        public string modelo { get => _modelo; set => _modelo = value; }
        public int km { get => _km; set => _km = value; }
        public double precio { get => _precio; set => _precio = value; }
        //modificador override, modificara el valor escrito en la clase base
        public override string ToString()
    
        {
            //devuelve los valores usados y contatena la oracion
            return "Marca: " + marca + ", modelo: " + modelo + " con un precio de " + precio;
        }
 
    }