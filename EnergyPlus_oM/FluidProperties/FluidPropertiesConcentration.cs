////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class FluidProperties:Concentration : BHoMObject
////{
////[Description("should not be any of the defaults (Water, EthyleneGlycol, or PropyleneGlycol)")]
////public virtual object-list FluidName { get; set; } = new object-list;
////[Description("Density Units are kg/m3")]
////public virtual choice FluidPropertyType { get; set; } = new choice;
////[Description("Enter the name of a FluidProperties:Temperatures object.")]
////public virtual object-list TemperatureValuesName { get; set; } = new object-list;
////[Description("Glycol concentration for this list of properties entered as a fraction")]
////public virtual real Concentration { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue9 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue10 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue11 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue12 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue13 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue14 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue15 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue16 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue17 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue18 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue19 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue20 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue21 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue22 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue23 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue24 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue25 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue26 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue27 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue28 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue29 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue30 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue31 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue32 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue33 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue34 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue35 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue36 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue37 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue38 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue39 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue40 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue41 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue42 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue43 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue44 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue45 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue46 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue47 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue48 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue49 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue50 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue51 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue52 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue53 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue54 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue55 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue56 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue57 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue58 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue59 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue60 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue61 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue62 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue63 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue64 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue65 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue66 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue67 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue68 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue69 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue70 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue71 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue72 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue73 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue74 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue75 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue76 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue77 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue78 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue79 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue80 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue81 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue82 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue83 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue84 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue85 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue86 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue87 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue88 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue89 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue90 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue91 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue92 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue93 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue94 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue95 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue96 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue97 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue98 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue99 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue100 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue101 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue102 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue103 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue104 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue105 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue106 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue107 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue108 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue109 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue110 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue111 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue112 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue113 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue114 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue115 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue116 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue117 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue118 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue119 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue120 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue121 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue122 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue123 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue124 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue125 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue126 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue127 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue128 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue129 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue130 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue131 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue132 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue133 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue134 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue135 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue136 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue137 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue138 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue139 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue140 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue141 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue142 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue143 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue144 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue145 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue146 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue147 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue148 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue149 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue150 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue151 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue152 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue153 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue154 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue155 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue156 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue157 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue158 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue159 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue160 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue161 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue162 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue163 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue164 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue165 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue166 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue167 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue168 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue169 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue170 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue171 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue172 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue173 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue174 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue175 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue176 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue177 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue178 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue179 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue180 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue181 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue182 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue183 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue184 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue185 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue186 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue187 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue188 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue189 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue190 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue191 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue192 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue193 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue194 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue195 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue196 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue197 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue198 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue199 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue200 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue201 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue202 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue203 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue204 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue205 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue206 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue207 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue208 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue209 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue210 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue211 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue212 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue213 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue214 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue215 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue216 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue217 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue218 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue219 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue220 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue221 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue222 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue223 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue224 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue225 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue226 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue227 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue228 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue229 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue230 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue231 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue232 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue233 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue234 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue235 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue236 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue237 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue238 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue239 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue240 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue241 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue242 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue243 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue244 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue245 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue246 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue247 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue248 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue249 { get; set; } = new real;
////[Description("No description available")]
////public virtual real PropertyValue250 { get; set; } = new real;
////}
////}
