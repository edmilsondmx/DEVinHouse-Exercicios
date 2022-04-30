class Aluno{
    nome:string = '';
    matricula:number = 0;
    passou:boolean = false;

    aprovado(media:number):boolean{
        if(media >= 7 ){
            this.passou = true;
        }else{
            this.passou = false;
        }
        return this.passou;
     }
};

interface Nota{
    cadeira:string;
    ponto:number;
    aluno:Aluno;
}

export { Aluno, Nota };