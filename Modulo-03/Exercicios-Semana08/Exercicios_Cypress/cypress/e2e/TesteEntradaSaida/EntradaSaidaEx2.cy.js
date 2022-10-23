context('TestesEntradaSaidaEx2', () => {
    
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

    it('testeImgEx2_entrada1', () => {

        cy.get('#txtN1').type('Caneta')
        cy.get('#txtV1').type(234)

        cy.get('#txtN2').type('FolhaA4')
        cy.get('#txtV2').type(530)

        cy.get('input').contains('Enviar').click()

        cy.get('table tbody tr').should('have.length', 3)

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index == 1)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    expect(nome).to.equal('Caneta')
                })
                
            if(index == 2)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    expect(nome).to.equal('FolhaA4')
                })
        })

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index == 1)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    expect(valor).to.equal('234')
                })
                
            if(index == 2)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    expect(valor).to.equal('530')
                })
        })

    });

    it('testeImgEx2_entrada2', () => {

        cy.get('#txtN1').type('Lápis')
        cy.get('#txtV1').type(4320)
        
        cy.get('input').contains('Enviar').click()

        cy.get('table tbody tr').should('have.length', 2)

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index == 1)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    expect(nome).to.equal('Lápis')
                })
        })

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index == 1)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    expect(valor).to.equal('4320')
                })
        })
    });

    it('testeImgEx2_entrada3', () => {

        cy.get('#txtN1').type('Bolsas')
        cy.get('#txtV1').type(135)

        cy.get('#txtN2').type('Cadernos')
        cy.get('#txtV2').type(1200)

        cy.get('#txtN3').type('Livros')
        cy.get('#txtV3').type(1200)
        
        cy.get('input').contains('Enviar').click()

        cy.get('table tbody tr').should('have.length', 4)

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index == 1)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    expect(nome).to.equal('Bolsas')
                })
                
            if(index == 2)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    expect(nome).to.equal('Cadernos')
                })

            if(index == 3)
                cy.get($el).find('#pNome')
                .invoke('text').then(nome => {
                    expect(nome).to.equal('Livros')
                })
        })

        cy.get('tbody tr')
        .each(($el, index) => {
            if(index == 1)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    expect(valor).to.equal('135')
                })
                
            if(index == 2)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    expect(valor).to.equal('1200')
                })

            if(index == 3)
                cy.get($el).find('#pValor')
                .invoke('text').then(valor => {
                    expect(valor).to.equal('1200')
                })
        })

    });
});