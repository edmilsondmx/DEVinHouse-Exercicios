const cidades = [
    { nome: 'Patos de Minas', populacao: 153585 },
    { nome: 'Lages', populacao: 157349 },
    { nome: 'Ibiúna', populacao: 79479 },
    { nome: 'Maringá', populacao: 403063 },
    { nome: 'Curitiba', populacao: 1963726 },
    { nome: 'Florianópolis', populacao: 508826 },
    { nome: 'Pato Branco', populacao: 84779 },
];

const mais200milHabitantes = cidades.filter(item => item.populacao > 200000);
const emOrdem = mais200milHabitantes.sort((a, b)=> b.populacao - a.populacao);
console.log(emOrdem);