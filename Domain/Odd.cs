using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Odd
    {
        public int Id { get; set; }
        public int IdMatchNext { get; set; }
        public int IdCompetition { get; set; }
        public DateTime Data { get; set; }
        public string TeamHome { get; set; }
        public string TeamAway { get; set; }
        public int IdTeamHome { get; set; }
        public int IdTeamAway { get; set; }
        public double PartidaVencedor_Casa { get; set; }
        public double PartidaVencedor_Empate { get; set; }
        public double PartidaVencedor_Visitante { get; set; }
        public double NumeroGols_0 { get; set; }
        public double NumeroGols_1 { get; set; }
        public double NumeroGols_2 { get; set; }
        public double NumeroGols_3 { get; set; }
        public double NumeroGols_4 { get; set; }
        public double NumeroGols_5Mais { get; set; }
        public double ResultadoCorreto_Casa_1x0 { get; set; }
        public double ResultadoCorreto_Casa_2x0 { get; set; }
        public double ResultadoCorreto_Casa_2x1 { get; set; }
        public double ResultadoCorreto_Casa_3x0 { get; set; }
        public double ResultadoCorreto_Casa_3x1 { get; set; }
        public double ResultadoCorreto_Casa_3x2 { get; set; }
        public double ResultadoCorreto_Casa_4x0 { get; set; }
        public double ResultadoCorreto_Casa_QualquerOutro { get; set; }
        public double ResultadoCorreto_Empate_0x0 { get; set; }
        public double ResultadoCorreto_Empate_1x1 { get; set; }
        public double ResultadoCorreto_Empate_2x2 { get; set; }
        public double ResultadoCorreto_Empate_QualquerOutro { get; set; }
        public double ResultadoCorreto_Visitante_1x0 { get; set; }
        public double ResultadoCorreto_Visitante_2x0 { get; set; }
        public double ResultadoCorreto_Visitante_2x1 { get; set; }
        public double ResultadoCorreto_Visitante_3x0 { get; set; }
        public double ResultadoCorreto_Visitante_3x1 { get; set; }
        public double ResultadoCorreto_Visitante_3x2 { get; set; }
        public double ResultadoCorreto_Visitante_4x0 { get; set; }
        public double ResultadoCorreto_Visitante_QualquerOutro { get; set; }
        public double ResultadoCorretoGrupo_Casa_1x0_2x0_2x1 { get; set; }
        public double ResultadoCorretoGrupo_Casa_3x0_3x1_4x0 { get; set; }
        public double ResultadoCorretoGrupo_Casa_0x0 { get; set; }
        public double ResultadoCorretoGrupo_Casa_1x1_2x2 { get; set; }
        public double ResultadoCorretoGrupo_Visitante_1x0_2x0_2x1 { get; set; }
        public double ResultadoCorretoGrupo_Visitante_3x0_3x1_4x0 { get; set; }
        public double ResultadoCorretoGrupo_3x3_4x4 { get; set; }
        public double ResultadoCorretoGrupo_Casa_QualquerOutro { get; set; }
        public double ResultadoCorretoGrupo_Visitante_QualquerOutro { get; set; }
        public double ResultadoCorretoGrupo_EmpateComGols { get; set; }
        public double ResultadoCorretoGrupo_QualquerOutroResultado { get; set; }
        public double DuplaHipotese_CasaOuEmpate { get; set; }
        public double DuplaHipotese_EmpateOuVisitante { get; set; }
        public double DuplaHipotese_CasaOuVisitante { get; set; }
        public double TotalGols_MaisDe_05 { get; set; }
        public double TotalGols_MaisDe_15 { get; set; }
        public double TotalGols_MaisDe_25 { get; set; }
        public double TotalGols_MaisDe_35 { get; set; }
        public double TotalGols_MenosDe_05 { get; set; }
        public double TotalGols_MenosDe_15 { get; set; }
        public double TotalGols_MenosDe_25 { get; set; }
        public double TotalGols_MenosDe_35 { get; set; }
        public double HandicapResultado_Casa_Menos20 { get; set; }
        public double HandicapResultado_Casa_Menos10 { get; set; }
        public double HandicapResultado_Casa_Mais10 { get; set; }
        public double HandicapResultado_Casa_Mais20 { get; set; }
        public double HandicapResultado_Empate_Mais20 { get; set; }
        public double HandicapResultado_Empate_Mais10 { get; set; }
        public double HandicapResultado_Empate_Menos10 { get; set; }
        public double HandicapResultado_Empate_Menos20 { get; set; }
        public double HandicapResultado_Visitante_Mais20 { get; set; }
        public double HandicapResultado_Visitante_Mais10 { get; set; }
        public double HandicapResultado_Visitante_Menos10 { get; set; }
        public double HandicapResultado_Visitante_Menos20 { get; set; }
        public double ResultadoParaAmbosMarcarem_CasaSim { get; set; }
        public double ResultadoParaAmbosMarcarem_CasaNao { get; set; }
        public double ResultadoParaAmbosMarcarem_VisitanteSim { get; set; }
        public double ResultadoParaAmbosMarcarem_VisitanteNao { get; set; }
        public double ResultadoParaAmbosMarcarem_EmpateSim { get; set; }
        public double ResultadoParaAmbosMarcarem_EmpateNao { get; set; }
        public double ParaAmbosMarcarem_Sim { get; set; }
        public double ParaAmbosMarcarem_Nao { get; set; }
        public double ParaCasaMarcar_Sim { get; set; }
        public double ParaCasaMarcar_Nao { get; set; }
        public double ParaVisitanteMarcar_Sim { get; set; }
        public double ParaVisitanteMarcar_Nao { get; set; }
        public double TimeCasaGols_NaoMarcar { get; set; }
        public double TimeCasaGols_MarcarExatamente1 { get; set; }
        public double TimeCasaGols_MarcarExatamente2 { get; set; }
        public double TimeCasaGols_MarcarExatamente3 { get; set; }
        public double TimeCasaGols_MarcarExatamente4 { get; set; }
        public double TimeVisitanteGols_NaoMarcar { get; set; }
        public double TimeVisitanteGols_MarcarExatamente1 { get; set; }
        public double TimeVisitanteGols_MarcarExatamente2 { get; set; }
        public double TimeVisitanteGols_MarcarExatamente3 { get; set; }
        public double TimeVisitanteGols_MarcarExatamente4 { get; set; }
        public double MargemVitoria_Casa1 { get; set; }
        public double MargemVitoria_Casa2 { get; set; }
        public double MargemVitoria_Casa3Mais { get; set; }
        public double MargemVitoria_Visitante1 { get; set; }
        public double MargemVitoria_Visitante2 { get; set; }
        public double MargemVitoria_Visitante3Mais { get; set; }
        public double MargemVitoria_SemGols { get; set; }
        public double MargemVitoria_EmpateComGols { get; set; }
        public double TimeAMarcarPrimeiro_Casa { get; set; }
        public double TimeAMarcarPrimeiro_Nenhum { get; set; }
        public double TimeAMarcarPrimeiro_Visitante { get; set; }
        public double TimeAMarcarPorUltimo_Casa { get; set; }
        public double TimeAMarcarPorUltimo_Nenhum { get; set; }
        public double TimeAMarcarPorUltimo_Visitante { get; set; }
        public double IntervaloResultado_Casa { get; set; }
        public double IntervaloResultado_Empate { get; set; }
        public double IntervaloResultado_Visitante { get; set; }
        public double IntervaloFinalJogo_CasaCasa { get; set; }
        public double IntervaloFinalJogo_CasaEmpate { get; set; }
        public double IntervaloFinalJogo_CasaVisitante { get; set; }
        public double IntervaloFinalJogo_EmpateCasa { get; set; }
        public double IntervaloFinalJogo_EmpateEmpate { get; set; }
        public double IntervaloFinalJogo_EmpateVisitante { get; set; }
        public double IntervaloFinalJogo_VisitanteCasa { get; set; }
        public double IntervaloFinalJogo_VisitanteEmpate { get; set; }
        public double IntervaloFinalJogo_VisitanteVisitante { get; set; }
        public double IntervaloResultadoCorreto_Casa_1x0 { get; set; }
        public double IntervaloResultadoCorreto_Casa_2x0 { get; set; }
        public double IntervaloResultadoCorreto_Empate_0x0 { get; set; }
        public double IntervaloResultadoCorreto_Empate_1x1 { get; set; }
        public double IntervaloResultadoCorreto_Visitante_1x0 { get; set; }
        public double IntervaloResultadoCorreto_Visitante_2x0 { get; set; }
        public double IntervaloResultadoCorreto_Outros { get; set; }
        public double GOALSCORER_Casa_CentroAvante { get; set; }
        public double GOALSCORER_Casa_PontaDireita { get; set; }
        public double GOALSCORER_Casa_PontaEsquerda { get; set; }
        public double GOALSCORER_Casa_QualquerOutroJogador { get; set; }
        public double GOALSCORER_Visitante_CentroAvante { get; set; }
        public double GOALSCORER_Visitante_PontaDireita { get; set; }
        public double GOALSCORER_Visitante_PontaEsquerda { get; set; }
        public double GOALSCORER_Visitante_QualquerOutroJogador { get; set; }
        public double GOALSCORER_Casa_MeiaAtacante { get; set; }
        public double GOALSCORER_Visitante_MeiaAtacante { get; set; }
        public double GOALSCORER_SemMarcadorDeGol { get; set; }
        public double TimeGols_Casa0 { get; set; }
        public double TimeGols_Visitante0 { get; set; }
        public double TimeGols_Casa1 { get; set; }
        public double TimeGols_Visitante1 { get; set; }
        public double TimeGols_Casa2 { get; set; }
        public double TimeGols_Visitante2 { get; set; }
        public double TimeGols_Casa3 { get; set; }
        public double TimeGols_Visitante3 { get; set; }
        public double TimeGols_Casa4 { get; set; }
        public double TimeGols_Visitante4 { get; set; }
        public double TimeGols_Casa5mais { get; set; }
        public double TimeGols_Visitante5mais { get; set; }
        public double ParaOTimeMarcarSIMNAO_CasaSim { get; set; }
        public double ParaOTimeMarcarSIMNAO_VisitanteSim { get; set; }
        public double ParaOTimeMarcarSIMNAO_AmbasMarcam { get; set; }
        public double ParaOTimeMarcarSIMNAO_CasaNao { get; set; }
        public double ParaOTimeMarcarSIMNAO_VisitanteNao { get; set; }
        public double HandicapAsiatico_Casa_00 { get; set; }
        public double HandicapAsiatico_Casa_Menos05 { get; set; }
        public double HandicapAsiatico_Casa_Mais05 { get; set; }
        public double HandicapAsiatico_Casa_00_Menos05 { get; set; }
        public double HandicapAsiatico_Casa_00_Mais05 { get; set; }
        public double HandicapAsiatico_Visitante_00 { get; set; }
        public double HandicapAsiatico_Visitante_Menos05 { get; set; }
        public double HandicapAsiatico_Visitante_Mais05 { get; set; }
        public double HandicapAsiatico_Visitante_00_Menos05 { get; set; }
        public double HandicapAsiatico_Visitante_00_Mais05 { get; set; }
    }
}