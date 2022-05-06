interface IBase{
    id:number;
    titulo: string;
    enderecoImg: string;
    descricao:string;

}

export interface ICardapio extends IBase {
    preco: number;
};

export interface IMenu extends IBase {
    rota:string;
}