context('TestesEntradaSaidaEx1', () => {
    
    before(() => {
        cy.visit('https://localhost:44360/ControleEntradasSaidas.aspx')
    });

    afterEach(() => {
        cy.get('input').contains('Limpar').click()

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

    it('testeImgEx1_entrada1', () => {

        cy.get('#txtN1').type('Boneca')
        cy.get('#txtV1').type(4)

        cy.get('#txtN2').type('Carrinho')
        cy.get('#txtV2').type(1)

        cy.get('#txtN3').type('Doces')
        cy.get('#txtV3').type(5)

        cy.get('#txtN4').type('Refrigerante')
        cy.get('#txtV4').type(6)

        cy.get('input').contains('Enviar').click()

        cy.get('table tbody tr').should('have.length', 5)

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index > 0)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1)
                        expect(nome).to.equal('Boneca')
                    
                    if(index == 2)
                        expect(nome).to.equal('Carrinho')

                    if(index == 3)
                        expect(nome).to.equal('Doces')

                    if(index == 4)
                        expect(nome).to.equal('Refrigerante')
                })
        })

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index > 0)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    if(index == 1)
                        expect(valor).to.equal('4')

                    if(index == 2)
                        expect(valor).to.equal('1')

                    if(index == 3)
                        expect(valor).to.equal('5')

                    if(index == 4)
                        expect(valor).to.equal('6')
                })
        })
    });

    it('testeImgEx1_entrada2', () => {

        cy.get('#txtN1').type('Boneca')
        cy.get('#txtV1').type(78)

        cy.get('#txtN2').type('Bolo')
        cy.get('#txtV2').type(3)

        cy.get('#txtN3').type('Doces')
        cy.get('#txtV3').type(8)

        cy.get('input').contains('Enviar').click()
        
        cy.get('table tbody tr').should('have.length', 4)

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index > 0)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1)
                        expect(nome).to.equal('Boneca')

                    if(index == 2)
                        expect(nome).to.equal('Bolo')

                    if(index == 3)
                        expect(nome).to.equal('Doces')
                })
        })

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index > 0)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    if(index == 1)
                        expect(valor).to.equal('78')

                    if(index == 2)
                        expect(valor).to.equal('3')

                    if(index == 3)
                        expect(valor).to.equal('8')
                })
        })
    });

    it('testeImgEx1_entrada3', () => {

        cy.get('#txtN1').type('Café')
        cy.get('#txtV1').type(2)

        cy.get('#txtN2').type('Coxinha')
        cy.get('#txtV2').type(3)

        cy.get('#txtN3').type('Pavê')
        cy.get('#txtV3').type(1)

        cy.get('#txtN4').type('Bolo Seco')
        cy.get('#txtV4').type(1)

        cy.get('#txtN5').type('Gelatina')
        cy.get('#txtV5').type(2)

        cy.get('input').contains('Enviar').click()
        
        cy.get('table tbody tr').should('have.length', 6)

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index > 0)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    if(index == 1)
                        expect(nome).to.equal('Café')
                    if(index == 2)
                        expect(nome).to.equal('Coxinha')
                    if(index == 3)
                        expect(nome).to.equal('Pavê')
                    if(index == 4)
                        expect(nome).to.equal('Bolo Seco')
                    if(index == 5)
                        expect(nome).to.equal('Gelatina')
                })
        })

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index > 0)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    if(index == 1)
                        expect(valor).to.equal('2')
                    if(index == 2)
                        expect(valor).to.equal('3')
                    if(index == 3)
                        expect(valor).to.equal('1')
                    if(index == 4)
                        expect(valor).to.equal('1')
                    if(index == 5)
                        expect(valor).to.equal('2')
                })
        })

    });
});