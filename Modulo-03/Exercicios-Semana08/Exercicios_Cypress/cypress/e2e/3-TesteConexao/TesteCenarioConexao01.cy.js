context('testeCenarioConexao01', () => {
    after(() => {
        for (let i = 1; i <= 7; i++) {
            let txt = `#txtN${i}`
            let vlr = `#txtV${i}`

            cy.get('#form1')
            .each(($el) => {

                cy.get($el).find(txt)
                .invoke('text').then(val => {
                    expect(val).to.equal('')
                })
                cy.get($el).find(vlr)
                .invoke('text').then(val => {
                    expect(val).to.equal('')
                })
            })
        }
    });
    it('TesteConexao01', () => {
        cy.visit('https://localhost:44360/CalcSimples.aspx')

        cy.get('#txtN1').type(10)
        cy.get('#txtN2').type(123)

        cy.get('input').contains('Calcular').click()

        cy.get('#lbResultado').invoke('text').then(($result) => {
            expect($result).to.be.equal('133')
        })

        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(97)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(70)

        cy.get('input').contains('Calcular').click()
       
        cy.get('#lbResultado').invoke('text').then(($result) => {
            expect($result).to.be.equal('27')
        })
        
        cy.get('input').contains('Limpar').click()
        
        cy.visit('https://localhost:44360/ControleEntradasSaidas.aspx')

        cy.get('#txtN1').type('Pássaros')
        cy.get('#txtV1').type(133)

        cy.get('#txtN2').type('Peixes')
        cy.get('#txtV2').type(27)

        cy.get('input').contains('Enviar').click()

        cy.get('table tbody tr').should('have.length', 3)

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index > 0){
                cy.get($el).find('#pNome').invoke('text').then(nome =>{
                    if(index == 1)
                        expect(nome).to.be.equal('Pássaros')

                    if(index == 2)
                        expect(nome).to.be.equal('Peixes')
                })

                cy.get($el).find('#pValor').invoke('text').then(valor =>{
                    if(index == 1)
                        expect(valor).to.be.equal('133')

                    if(index == 2)
                        expect(valor).to.be.equal('27')
                })
            }
        })

        cy.get('#lbVTotal').invoke('text').then(val =>{
            expect(val).to.be.equal('Valor Total: 160')
        })

        cy.get('input').contains('Limpar').click()
    });
});