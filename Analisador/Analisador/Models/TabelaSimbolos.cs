using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    class TabelaSimbolos {

        public int identificador;
        public string rotulo;
        public Estado estadoReconhecedor;
        public int linha;

        public TabelaSimbolos(int identificador, string rotulo, Estado estadoReconhecedor, int linha) {
            this.identificador = identificador;
            this.rotulo = rotulo;
            this.estadoReconhecedor = estadoReconhecedor;
            this.linha = linha;
        }

    }
}
