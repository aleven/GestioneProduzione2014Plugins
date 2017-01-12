using System;
using VS2005Commons;
using System.Data;
namespace GestioneProduzione2014Data
{


    partial class GestioneProduzione2009DataSet
    {
        public void AggiornaPrezziListinoRicambi()
        {
            if ((t26_formule_prezzi == null | t26_formule_prezzi.Rows.Count == 0))
            {
                throw new Exception("Caricare in memoria le formule prezzi!");
            }

            foreach (ListinoRicambiRow articolo in ListinoRicambi)
            {
                // Se il prezzo forzato e' nullo o zero faccio i calcoli con la formula
                if (articolo.Ist20_prezzo_forzatoNull() || articolo.t20_prezzo_forzato == 0)
                {
                    foreach (t26_formule_prezziRow rigaFormulaPrezzi in t26_formule_prezzi)
                    {
                        decimal costo_articolo = 0;
                        decimal prezzo_calcolato = 0;

                        if (!articolo.Ist20_prezzoNull())
                        {
                            costo_articolo = articolo.t20_prezzo;
                        }
                        // Verifico in quale range rientro
                        if (costo_articolo >= rigaFormulaPrezzi.t26_formula_da & costo_articolo < rigaFormulaPrezzi.t26_formula_a)
                        {
                            //Verifico se devo usare un prezzo fisso o calcolarlo
                            if (rigaFormulaPrezzi.Ist26_prezzo_fissoNull())
                            {
                                prezzo_calcolato = articolo.t20_prezzo * rigaFormulaPrezzi.t26_fattore;

                                if ((rigaFormulaPrezzi.Ist26_arrotondamentoNull()))
                                {
                                    prezzo_calcolato = Convert.ToDecimal(PrezziUtils.arrotondaPrezzo(Convert.ToDouble(prezzo_calcolato), PrezziUtils.arrotondamento.nessuno));
                                }
                                else if (rigaFormulaPrezzi.t26_arrotondamento == Convert.ToDecimal(0.5))
                                {
                                    prezzo_calcolato = Convert.ToDecimal(PrezziUtils.arrotondaPrezzo(Convert.ToDouble(prezzo_calcolato), PrezziUtils.arrotondamento.mezzo_euro_successivo));
                                }
                                else if (rigaFormulaPrezzi.t26_arrotondamento == 1)
                                {
                                    prezzo_calcolato = Convert.ToDecimal(PrezziUtils.arrotondaPrezzo(Convert.ToDouble(prezzo_calcolato), PrezziUtils.arrotondamento.euro_successivo));
                                }
                                else
                                {
                                    prezzo_calcolato = Convert.ToDecimal(PrezziUtils.arrotondaPrezzo(Convert.ToDouble(prezzo_calcolato), PrezziUtils.arrotondamento.nessuno));
                                }
                            }
                            else
                            {
                                prezzo_calcolato = rigaFormulaPrezzi.t26_prezzo_fisso;
                            }
                            articolo.t20_prezzo = prezzo_calcolato;
                            break;
                        }
                    }
                }
                else
                {
                    articolo.t20_prezzo = articolo.t20_prezzo_forzato;
                }
            }
        }
    }
}
