function sleep(valor){
    return new Promise((resolve, reject) => {
        setTimeout(() => resolve(console.log(valor, "Promise resolvida com sucesso!")), 3000);
    });
};

sleep('Sucesso:')