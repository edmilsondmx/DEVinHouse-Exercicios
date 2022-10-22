context('TestesEntradaSaidaEx2', () => {
    
    before(() => {
        cy.visit('https://localhost:44360/ControleEntradasSaidas.aspx')
    });

    afterEach(() => {
        cy.get('input').contains('Enviar').click()
        cy.get('input').contains('Limpar').click()
        
    });

    it('testeImgEx2_entrada1', () => {

        cy.get('#txtN1').type('Caneta')
        cy.get('#txtV1').type(234)

        cy.get('#txtN2').type('FolhaA4')
        cy.get('#txtV2').type(530)

    });

    it('testeImgEx2_entrada2', () => {

        cy.get('#txtN1').type('Lápis')
        cy.get('#txtV1').type(4320)
    });

    it('testeImgEx2_entrada3', () => {

        cy.get('#txtN1').type('Bolsas')
        cy.get('#txtV1').type(135)

        cy.get('#txtN2').type('Cadernos')
        cy.get('#txtV2').type(1200)

        cy.get('#txtN3').type('Livros')
        cy.get('#txtV3').type(1200)

    });
});