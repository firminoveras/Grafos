using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grafos {
    public partial class Grafos : Form {
        bool isDirecionado = false;
                
        public Grafos() {
            InitializeComponent();
            atualizarStatus();
        }

        // Botão para inserir vértice
        private void mInserir_Click(object sender, EventArgs e) {
            if(mVertice1.Text.Length > 0 && mVertice2.Text.Length > 0) {
                mListaVertices.Items.Add("G=(" + mVertice1.Text + "," + mVertice2.Text + ")");
                mVertice1.Text = "";
                mVertice2.Text = "";
            }
            atualizarMatriz();
            atualizarAdjacencias();
            atualizarStatus();
        }

        // Botão para alternar entre grafo direcionado e não-direcionado
        private void mIsDirecionado_Click(object sender, EventArgs e) {
            isDirecionado = !isDirecionado;
            ((Button)sender).Text = isDirecionado ? "→" : "↔";
            atualizarMatriz();
            atualizarAdjacencias();
            atualizarStatus();
        }

        // Botão que exclui um vértice selecionado da lista
        private void mExcluir_Click(object sender, EventArgs e) {     
            if(mListaVertices.SelectedItems.Count > 0)
            mListaVertices.Items.RemoveAt(mListaVertices.SelectedIndex);
            atualizarMatriz();
            atualizarAdjacencias();
            atualizarStatus();
        }

        // Botão para limpar todos os vértices
        private void mLimpar_Click(object sender, EventArgs e) {
            mListaVertices.Items.Clear();
            atualizarMatriz();
            atualizarAdjacencias();
            atualizarStatus();
        }

        public void atualizarMatriz() {
            List<string> pares = new List<string>(); 
            string vertices = "";
            // Cria os pares e enumera as colunas da matriz
            string matrizColunas = "";
            foreach(string linha in mListaVertices.Items) {
                char v1 = linha.ToCharArray()[3];
                char v2 = linha.ToCharArray()[5];
                pares.Add(v1.ToString() + v2);
                if(!vertices.Contains(v1)) {
                    vertices += v1;
                    matrizColunas += v1 + " ";
                }
                if(!vertices.Contains(v2)) {
                    vertices += v2;
                    matrizColunas += v2 + " ";
                }
            }
            mMatrizColunas.Text = matrizColunas;

            // Enumera as linhas da matriz
            string matrizLinhas = "";
            foreach(char vertice in vertices.ToCharArray()) {
                matrizLinhas += vertice+ "\r\n";
            }
            mMatrizLinhas.Text = matrizLinhas;

            //Preenche a matriz
            mMatriz.Text = "";
            for(int i = 0; i < vertices.Length; i++) {
                for(int j = 0; j < vertices.Length; j++) {
                    string comp1 = vertices.ToCharArray()[i].ToString() + vertices.ToCharArray()[j].ToString();
                    string comp2 = vertices.ToCharArray()[j].ToString() + vertices.ToCharArray()[i].ToString();
                    int cont = 0;
                    foreach(string par in pares) {
                        if(isDirecionado) {
                            if(par == comp1) cont++;
                        } else {
                            if(par == comp1 || par == comp2) cont++;
                        }
                    }
                    mMatriz.Text += cont.ToString()+" ";     
                }
                mMatriz.Text += "\r\n";
            }

        }

        public void atualizarAdjacencias() {
            List<string> pares = new List<string>();
            string vertices = "";
            
            // Cria os pares e enumera as linhas da adjacencia
            string adjacenciasLinhas = "";
            foreach(string linha in mListaVertices.Items) {
                char v1 = linha.ToCharArray()[3];
                char v2 = linha.ToCharArray()[5];
                pares.Add(v1.ToString() + v2);
                if(!vertices.Contains(v1)) {
                    vertices += v1;
                    adjacenciasLinhas += v1 + "\r\n";
                }
                if(!vertices.Contains(v2)) {
                    vertices += v2;
                    adjacenciasLinhas += v2 + "\r\n";
                }
            }
            mAdjacenciasLinhas.Text = adjacenciasLinhas;

            //Preenche a lista
            mAdjacencias.Text = "";
            for(int i = 0; i < vertices.Length; i++) {
                for(int j = 0; j < vertices.Length; j++) {
                    string comp1 = vertices.ToCharArray()[i].ToString() + vertices.ToCharArray()[j].ToString();
                    string comp2 = vertices.ToCharArray()[j].ToString() + vertices.ToCharArray()[i].ToString();
                    int cont = 0;
                    foreach(string par in pares) {
                        if(isDirecionado) {
                            if(par == comp1) cont++;
                        } else {
                            if(par == comp1 || par == comp2) cont++;
                        }
                    }
                    if(cont>0)
                    mAdjacencias.Text += "→[" + vertices.ToCharArray()[j].ToString() +","+ cont.ToString() + "]";
                }
                mAdjacencias.Text += "\r\n";
            }
        }

        public void atualizarStatus() {
            // Cria os vertices
            string vertices = "";       
            foreach(string linha in mListaVertices.Items) {
                char v1 = linha.ToCharArray()[3];
                char v2 = linha.ToCharArray()[5];
                if(!vertices.Contains(v1)) {
                    vertices += v1;
                }
                if(!vertices.Contains(v2)) {
                    vertices += v2;
                }
            }

            // Escreve os estatus do grafo
            mStatus.Text = "Vértices: " + vertices.Length + "\r\n";
            mStatus.Text += "Arestas : " + mListaVertices.Items.Count + "\r\n";
            mStatus.Text += "Tipo    : " + ((isDirecionado) ? "": "Não-") + "Direcionado";
        }

    }
}