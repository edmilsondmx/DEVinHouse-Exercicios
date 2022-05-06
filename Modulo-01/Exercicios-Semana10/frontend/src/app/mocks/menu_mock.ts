import { IMenu } from "../models/interface";

 export const MENU_MOCK:IMenu[] = [
    {
        id: 1,
        titulo: "Lanches Artesanais",
        enderecoImg: "../../assets/imagens/hamburger.jpg",
        descricao:"Para cada tamanho de fome exste um hambúrger que acaba com ela perfeitamente!",
        rota:"/comidas"
    },
    {
        id: 2,
        titulo: "Bebidas diversas",
        enderecoImg: "../../assets/imagens/bebida.jpg",
        descricao:"Bebidas na medida da sua sede! Refrigerantes, Sucos, Cervejas e muito mais...",
        rota:"/bebidas"
    }
  ]