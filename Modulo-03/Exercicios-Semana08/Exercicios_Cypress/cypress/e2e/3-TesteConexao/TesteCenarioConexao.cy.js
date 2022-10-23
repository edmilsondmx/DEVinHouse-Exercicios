
context('testeCenarioConexao', () => {
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

        cy.get('#txtN1').type('Racão')
        cy.get('#txtV1').type(1000)

        cy.get('#txtN2').type('Petiscos')
        cy.get('#txtV2').type(30)

        cy.get('#txtN3').type('Coleira')
        cy.get('#txtV3').type(150)

        cy.get('#txtN4').type('Remédios')
        cy.get('#txtV4').type(1)

        cy.get('input').contains('Enviar').click()

        cy.get('table tbody tr').should('have.length', 5)
    });
});