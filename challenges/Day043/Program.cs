     public List<Object> Pdf = new ArrayList<>();

 
 public void AdicionarPagina(String pagina) {
        Pdf.add(pagina);
        System.out.println("Página adicionada: " + pagina);
    }

    public void AdicionarTexto(String texto) {
        Pdf.add(texto);
        System.out.println("Texto adicionado: " + texto);
    }

    public void AdicionarImagem(String imagem) {
        Pdf.add(imagem);
        System.out.println("Imagem adicionada: " + imagem);
    }

    public <T> void remover(T obj) {
        Pdf.remove(obj);
        System.out.println("Objeto removido: " + obj);
    }