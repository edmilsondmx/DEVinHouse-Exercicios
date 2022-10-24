context('testeCenarioConexao02', () => {

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
    
    it('TesteConexao02', () => {
        cy.visit('https://localhost:44360/CalcSimples.aspx')

        cy.get('#txtN1').type(10)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(100)

        cy.get('input').contains('Calcular').click()

        cy.get('#lbResultado').invoke('text').then(($result) => {
            expect($result).to.be.equal('1000')
        })

        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(90)
        cy.get('#rbFuncao_3').click()
        cy.get('#txtN2').type(3)

        cy.get('input').contains('Calcular').click()

        cy.get('#lbResultado').invoke('text').then(($result) => {
            expect($result).to.be.equal('30')
        })

        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(125)
        cy.get('#rbFuncao_0').click()
        cy.get('#txtN2').type(25)

        cy.get('input').contains('Calcular').click()

        cy.get('#lbResultado').invoke('text').then(($result) => {
            expect($result).to.be.equal('150')
        })

        cy.get('input').contains('Limpar').click()

        cy.get('#txtN1').type(2)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(1)

        cy.get('input').contains('Calcular').click()

        cy.get('#lbResultado').invoke('text').then(($result) => {
            expect($result).to.be.equal('1')
        })

        cy.visit('https://localhost:44360/ControleEntradasSaidas.aspx')

        cy.get('#txtN1').type('Ração')
        cy.get('#txtV1').type(1000)

        cy.get('#txtN2').type('Petiscos')
        cy.get('#txtV2').type(30)

        cy.get('#txtN3').type('Coleira')
        cy.get('#txtV3').type(150)

        cy.get('#txtN4').type('Remédios')
        cy.get('#txtV4').type(1)

        cy.get('input').contains('Enviar').click()

        cy.get('table tbody tr').should('have.length', 5)

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index > 0){
                cy.get($el).find('#pNome').invoke('text').then(nome =>{
                    if(index == 1)
                        expect(nome).to.be.equal('Ração')

                    if(index == 2)
                        expect(nome).to.be.equal('Petiscos')

                    if(index == 3)
                        expect(nome).to.be.equal('Coleira')

                    if(index == 4)
                        expect(nome).to.be.equal('Remédios')
                })

                cy.get($el).find('#pValor').invoke('text').then(valor =>{
                    if(index == 1)
                        expect(valor).to.be.equal('1000')

                    if(index == 2)
                        expect(valor).to.be.equal('30')

                    if(index == 3)
                        expect(valor).to.be.equal('150')

                    if(index == 4)
                        expect(valor).to.be.equal('1')
                })
            }
        })

        cy.get('#lbVTotal').invoke('text').then(val =>{
            expect(val).to.be.equal('Valor Total: 1181')
        })

        cy.get('input').contains('Limpar').click()
    });
});