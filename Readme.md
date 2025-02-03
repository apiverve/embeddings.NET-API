Text Embeddings API
============

Embeddings is a simple tool for generating text embeddings. It returns the text embeddings based on the text provided.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Text Embeddings API](https://apiverve.com/marketplace/api/embeddings)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.TextEmbeddings
```

Using the Package Manager:
```
nuget install APIVerve.API.TextEmbeddings
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.TextEmbeddings
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.TextEmbeddings".
5. Click on the APIVerve.API.TextEmbeddings package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the embeddings API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Text Embeddings API documentation is found here: [https://docs.apiverve.com/api/embeddings](https://docs.apiverve.com/api/embeddings).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Text Embeddings API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new TextEmbeddingsAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new TextEmbeddingsQueryOptions {
  text = "This is an example sentence."
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": [
    0.020913438871502876,
    0.0038885953836143017,
    0.020219264551997185,
    -0.0174271147698164,
    0.058373838663101196,
    0.0013058388140052557,
    0.031169278547167778,
    0.036202341318130493,
    -0.016447251662611961,
    -0.021026961505413055,
    -0.017448913305997849,
    -0.00020241069432813674,
    -0.097021311521530151,
    0.011951670981943607,
    -0.00013615125499200076,
    0.057473171502351761,
    0.039724484086036682,
    0.011273282580077648,
    0.016146162524819374,
    0.0020309595856815577,
    -0.00051569478819146752,
    0.046645514667034149,
    0.031510457396507263,
    0.020767210051417351,
    0.032665807753801346,
    -0.0052483389154076576,
    0.042996771633625031,
    0.015065365470945835,
    -0.060483306646347046,
    0.011922405101358891,
    0.037910211831331253,
    -0.016467256471514702,
    -0.015966664999723434,
    -0.012592880055308342,
    0.0028555775061249733,
    -0.024172959849238396,
    -0.012209104374051094,
    -0.0373905710875988,
    0.013218884356319904,
    -0.023397382348775864,
    -0.051628753542900085,
    -0.01375944446772337,
    -0.041175246238708496,
    -0.012488491833209992,
    -0.057461433112621307,
    -0.0018126349896192551,
    -0.047189250588417053,
    0.020345892757177353,
    -0.040326826274394989,
    -0.0086186286062002182,
    -0.0800088569521904,
    0.013111358508467674,
    0.029027868062257767,
    0.027438808232545853,
    -0.021260393783450127,
    0.04673321545124054,
    -0.032674048095941544,
    -0.075171060860157013,
    -0.026660285890102386,
    -0.04655374214053154,
    0.011978431604802609,
    0.015898300334811211,
    0.030946884304285049,
    -0.0045692962594330311,
    0.019095206633210182,
    -0.0078690182417631149,
    0.019389690831303596,
    0.046734694391489029,
    -0.068103402853012085,
    -0.018076905980706215,
    -0.037014685571193695,
    -0.027212370187044144,
    -0.021654058247804642,
    0.0019140007207170129,
    0.021022617816925049,
    -0.036188498139381409,
    0.023140883073210716,
    0.020508822053670883,
    0.033555205911397934,
    0.046301029622554779,
    0.007799927145242691,
    0.01212003268301487,
    -0.0096675530076026916,
    0.050316404551267624,
    -0.037396039813756943,
    -0.037636313587427139,
    -0.0068681202828884125,
    -0.0097658196464180946,
    -0.064294934272766113,
    0.053364470601081848,
    0.0012459758436307311,
    -0.03833925724029541,
    0.038365814834833145,
    0.028005924075841904,
    -0.027794048190116882,
    0.009759850800037384,
    0.059800907969474792,
    -0.041954319924116135,
    0.00986944418400526,
    0.052042517811059952,
    -0.049627624452114105,
    -0.057169996201992035,
    0.0024370416067540646,
    -0.010084716603159905,
    -0.070610262453556061,
    -0.0038347719237208366,
    -0.034609146416187286,
    0.044666986912488937,
    0.0053688627667725086,
    -0.0061259008944034576,
    0.049850441515445709,
    -0.029666444286704063,
    -0.016188828274607658,
    0.01224780734628439,
    -0.024757536128163338,
    0.060881201177835464,
    0.018759394064545631,
    -0.001942075090482831,
    -0.016928710043430328,
    -0.013732782565057278,
    0.041253924369812012,
    0.038073919713497162,
    0.01660572923719883,
    0.096910327672958374,
    0.029061486944556236,
    0.026717448607087135,
    0.0012974055716767907,
    0.07393675297498703,
    -0.022896921262145042,
    -0.065613001585006714,
    0.02307816781103611,
    0.049792636185884476,
    0.004671578761190176,
    -0.026786774396896362,
    0.0060979886911809444,
    -0.020654682070016861,
    0.0089407861232757568,
    -0.015248049050569534,
    0.047910712659358978,
    -0.016788555309176445,
    0.0017655873671174049,
    -0.011387968435883522,
    0.020057262852787971,
    -0.0030698664486408234,
    0.028197420760989189,
    -0.041228488087654114,
    -0.011199436150491238,
    -0.031541179865598679,
    -0.003043066244572401,
    0.031920317560434341,
    -0.0041620461270213127,
    0.0076464754529297352,
    0.047241125255823135,
    -0.019225867465138435,
    0.021277191117405891,
    0.036563757807016373,
    0.0035869341809302568,
    -0.0034037574660032988,
    -0.029245566576719284,
    0.070423208177089691,
    0.0052243238314986229,
    0.021204018965363503,
    0.019585264846682549,
    0.010266447439789772,
    -0.01102422084659338,
    0.004027513787150383,
    -0.0014465252170339227,
    0.0096337553113698959,
    -0.031900364905595779,
    0.020233454182744026,
    -0.011636443436145783,
    -0.049696318805217743,
    0.060180649161338806,
    -0.046293530613183975,
    -0.025541273877024651,
    0.024230565875768662,
    0.092164494097232819,
    0.036905732005834579,
    0.04191192239522934,
    -0.024234199896454811,
    -0.068676814436912537,
    0.050220735371112823,
    0.023910904303193092,
    -0.0026815223973244429,
    -0.006037016399204731,
    -0.033212482929229736,
    0.047960832715034485,
    -0.0352458618581295,
    -0.00819702073931694,
    0.0046065910719335079,
    -0.055269014090299606,
    -0.084337577223777771,
    -0.00863645225763321,
    -0.016717620193958282,
    0.042588140815496445,
    -0.047416180372238159,
    -0.022287586703896523,
    0.012816017493605614,
    0.016901614144444466,
    0.046847522258758545,
    -0.012051485478878021,
    0.030487734824419022,
    0.021954508498311043,
    -0.030707651749253273,
    -0.030381271615624428,
    0.074877098202705383,
    0.041223455220460892,
    -0.021335126832127571,
    -0.017587289214134216,
    0.013102760538458824,
    -0.024069936946034431,
    0.0016374007100239396,
    0.051767311990261078,
    -0.026993159204721451,
    0.013984622433781624,
    0.0017559363041073084,
    0.0404442697763443,
    -0.030249238014221191,
    -0.021796545013785362,
    -0.057344596832990646,
    0.00568657461553812,
    -0.018430491909384727,
    -0.013824698515236378,
    0.009230930358171463,
    -0.028359139338135719,
    0.10334613174200058,
    0.049678131937980652,
    -0.033358357846736908,
    0.013337974436581135,
    -0.0050314967520534992,
    0.0053984243422746658,
    -0.025344932451844215,
    0.013160105794668198,
    0.0083796344697475433,
    0.0331823006272316,
    0.011962753720581532,
    0.013265102170407772,
    -0.020196331664919853,
    0.057535361498594284,
    -0.026167554780840874,
    0.0014063570415601134,
    0.044258322566747665,
    -0.02034570649266243,
    0.067559957504272461,
    0.015921812504529953,
    -0.022912207990884781,
    0.014294006861746311,
    -0.0073086176998913288,
    -0.03639235720038414,
    -0.023909732699394226,
    -0.01975494809448719,
    -0.063667550683021545,
    -0.0033626491203904152,
    -0.013489304110407829,
    0.020730223506689072,
    -0.036564260721206665,
    -0.066765710711479187,
    0.0061111114919185638,
    0.042392481118440628,
    0.050789453089237213,
    -0.019748685881495476,
    0.02213599719107151,
    -0.0086321178823709488,
    -0.02007807232439518,
    -0.031103100627660751,
    -0.064406000077724457,
    -0.035824961960315704,
    0.022528788074851036,
    0.042978249490261078,
    0.026915352791547775,
    0.034691046923398972,
    0.0018348003504797816,
    -0.00097321072826161981,
    0.0038797275628894567,
    0.0092502878978848457,
    -0.042059458792209625,
    0.06879124790430069,
    0.012941320426762104,
    -0.0087883546948432922,
    -0.040467113256454468,
    0.0049116648733615875,
    0.05271809920668602,
    -0.034756630659103394,
    -0.056144122034311295,
    0.016593322157859802,
    -0.0730743482708931,
    0.042324714362621307,
    -0.038896277546882629,
    -0.047307241708040237,
    0.0042130737565457821,
    0.0038716667331755161,
    0.047890253365039825,
    0.010317846201360226,
    -0.0035017896443605423,
    0.060506287962198257,
    0.023219753056764603,
    -0.028640493750572205,
    0.021123334765434265,
    -0.013743378221988678,
    -0.022579755634069443,
    -0.0019653905183076859,
    -0.005866022314876318,
    0.0046920194290578365,
    -0.0057257860898971558,
    -0.013872629031538963,
    -0.023339273408055305,
    0.016930500045418739,
    -0.02291623130440712,
    -0.30311259627342224,
    0.016532527282834053,
    -0.0073138377629220486,
    -0.038453418761491776,
    0.028325596824288368,
    -0.034333538264036179,
    0.017689848318696022,
    -0.0477333702147007,
    -0.043319977819919586,
    0.047875162214040756,
    -0.034528575837612152,
    -0.025777524337172508,
    0.0078030414879322052,
    0.030420970171689987,
    0.027143476530909538,
    -0.0031769240740686655,
    -0.018009107559919357,
    -0.0029700545128434896,
    0.00924109760671854,
    0.045478709042072296,
    -0.00644893990829587,
    -0.058510132133960724,
    -0.015034626238048077,
    0.020103676244616508,
    0.0065013612620532513,
    0.07848716527223587,
    -0.051306527107954025,
    0.0051132258959114552,
    -0.0419691726565361,
    -0.018273100256919861,
    0.013427294790744782,
    -0.0094873989000916481,
    -0.0074499933980405331,
    -0.026686634868383408,
    -0.0026423195376992226,
    -0.022882793098688126,
    0.035620413720607758,
    -0.023972731083631516,
    -0.0046427696943283081,
    -0.0070502776652574539,
    -0.0020762069616466761,
    -0.032054238021373749,
    -0.0050736567936837673,
    -0.0056892917491495609,
    0.070123471319675446,
    -0.0081584826111793518,
    -0.027472419664263725,
    -0.050356507301330566,
    -0.034194078296422958,
    0.063384242355823517,
    -0.037099387496709824,
    0.016946680843830109,
    -0.015085598453879356,
    0.01739523746073246,
    -0.004119030199944973,
    -0.0072147445753216743,
    0.025773068889975548,
    -0.00062752008670941,
    -0.012486736290156841,
    -0.022131601348519325,
    -0.035089235752820969,
    -0.023527517914772034,
    -0.061962582170963287,
    -0.0056793210096657276,
    0.042754199355840683,
    -0.036305401474237442,
    0.0038337341975420713,
    -0.014627247117459774,
    0.085073255002498627,
    0.014594441279768944,
    -0.016666490584611893,
    0.017732374370098114,
    0.0045674964785575867,
    -0.067117206752300262,
    0.0022853354457765818,
    -0.0047142799012362957,
    0.0049621616490185261,
    -0.042356036603450775,
    0.013048751279711723,
    0.010415066033601761,
    -0.0638817697763443,
    -0.022607414051890373,
    0.010049904696643353,
    0.0016178642399609089,
    0.016217680647969246,
    -0.044183410704135895,
    0.029256295412778854,
    0.023553803563117981,
    -0.012062916532158852,
    -0.018692785874009132,
    0.077382929623126984,
    0.03246355801820755,
    -0.018057426437735558,
    0.0082539059221744537,
    0.045427951961755753,
    0.042300980538129807,
    0.016513755545020103,
    0.0015205643139779568,
    0.031705435365438461,
    -0.00483706034719944,
    0.022686401382088661,
    -0.051545258611440659,
    0.039149392396211624,
    -0.024085255339741707,
    -0.018372524529695511,
    -0.013856485486030579,
    -0.075737416744232178,
    0.026703882962465286,
    0.0091216359287500381,
    0.0063390224240720272,
    0.038998376578092575,
    -0.0039024851284921169,
    0.048439901322126389,
    -0.034901421517133713,
    -0.0072112539783120155,
    -0.0690765455365181,
    0.024632811546325684,
    0.064917139708995819,
    0.024177743121981621,
    0.00925503671169281,
    -0.0053644650615751743,
    0.038399241864681244,
    -0.0570799820125103,
    -0.025113558396697044,
    -0.11451447755098343,
    0.0011649364605545998,
    0.013080627657473087,
    0.012165166437625885,
    -0.022132497280836105,
    0.022319743409752846,
    -0.002795856911689043,
    -0.0017562899738550186,
    0.024832900613546371,
    -0.021108819171786308,
    -0.0048706876114010811,
    0.00029796894523315132,
    -0.053362786769866943,
    -0.055567376315593719,
    0.016876833513379097,
    -0.020018542185425758,
    0.021788228303194046,
    0.023696629330515862,
    0.023876335471868515,
    0.025065360590815544,
    0.020659904927015305,
    0.034588810056447983,
    0.0016126839909702539,
    -0.014425655826926231,
    -0.035967685282230377,
    0.011962534859776497,
    -0.0027410059701651335,
    -0.025911170989274979,
    -0.017753381282091141,
    -0.070513583719730377,
    0.01000291109085083,
    -0.016978278756141663,
    0.00787855964154005,
    -0.006834391038864851,
    -0.0031403545290231705,
    -0.038461744785308838,
    -0.011204618960618973,
    -0.039559103548526764,
    -0.051384612917900085,
    -0.017450928688049316,
    0.0059392717666924,
    0.056034859269857407,
    -0.043216630816459656,
    -0.012803588062524796,
    -0.020516496151685715,
    0.039315555244684219,
    0.035740714520215988,
    -0.013912135735154152,
    -0.0499144084751606,
    0.055113166570663452,
    0.0041548991575837135,
    0.030398145318031311,
    -0.013620026409626007,
    0.0033737579360604286,
    0.052642542868852615,
    0.029715117067098618,
    0.026958230882883072,
    -0.0324072502553463,
    -0.0039350595325231552,
    -0.018922645598649979,
    0.072335049510002136,
    -0.023934714496135712,
    0.015033860690891743,
    -0.021686378866434097,
    -0.021266927942633629,
    0.019122719764709473,
    0.00043356590322218835,
    0.017702195793390274,
    -0.0086860675364732742,
    0.0015115662245079875,
    -0.05308229848742485,
    -0.082083038985729218,
    0.02550378255546093,
    -0.0042300773784518242,
    -0.012984282337129116,
    0.01835213229060173,
    0.0083283493295311928,
    -0.020624907687306404,
    -0.038265109062194824,
    0.013368451036512852,
    0.043930765241384506,
    -0.087259776890277863,
    0.0615447461605072,
    0.0091773960739374161,
    -0.0062441551126539707,
    0.031890228390693665,
    -0.022034384310245514,
    -0.053237657994031906,
    -0.053525213152170181,
    -0.019935339689254761,
    0.013232547789812088,
    -0.05803351104259491,
    -0.031940657645463943,
    -0.030117237940430641,
    0.016657417640089989,
    -0.044994622468948364,
    -0.0018035948742181063,
    -0.03681047260761261,
    -0.021778300404548645,
    -0.023375660181045532,
    -0.014054625295102596,
    0.029175847768783569,
    -0.0356873944401741,
    -0.018750617280602455,
    0.073069564998149872,
    -0.044997259974479675,
    0.0052745039574801922,
    -0.010367122478783131,
    0.017213571816682816,
    0.065861470997333527,
    -0.026516694575548172,
    -0.001307034632191062,
    -0.024004820734262466,
    0.010157167911529541,
    0.0060526072047650814,
    0.052999336272478104,
    0.015243264846503735,
    0.015783766284585,
    -0.010517864488065243,
    -0.042581655085086823,
    0.0059634232893586159,
    0.01825241930782795,
    0.018271893262863159,
    0.017822423949837685,
    -0.016235848888754845,
    0.061428625136613846,
    0.0055922870524227619,
    -0.0058137518353760242,
    -0.0016470582922920585,
    -0.023310590535402298,
    0.052313454449176788,
    -0.015119425021111965,
    -0.043543204665184021,
    0.00020689754455816,
    -0.028985261917114258,
    -0.008504956029355526,
    0.057136993855237961,
    -0.0028150980360805988,
    -0.041585009545087814,
    0.034946057945489883,
    0.053319830447435379,
    0.044053874909877777,
    0.0067723933607339859,
    0.021708082407712936,
    0.047077082097530365,
    -0.013913395814597607,
    -0.0053588338196277618,
    -0.0692051351070404,
    -0.009039171040058136,
    0.015085604973137379,
    0.0343647301197052,
    0.017164662480354309,
    -0.016782904043793678,
    -0.010778710246086121,
    0.01920810155570507,
    -0.041701853275299072,
    -0.00098338862881064415,
    0.050873149186372757,
    -0.013081680983304977,
    0.0044110477901995182,
    0.03941505029797554,
    -0.044998154044151306,
    0.020613737404346466,
    0.016777699813246727,
    -0.051976166665554047,
    -0.034134939312934875,
    -0.011121373623609543,
    0.033837832510471344,
    0.003491497365757823,
    0.0114882942289114,
    0.026351872831583023,
    -0.011361147277057171,
    0.071975201368331909,
    0.068449154496192932,
    -0.013348199427127838,
    0.036552276462316513,
    -0.032188732177019119,
    0.041737724095582962,
    0.00346323917619884,
    -0.00853241141885519,
    -0.053557369858026505,
    0.0026144753210246563,
    -0.013708780519664288,
    -0.090660795569419861,
    0.008543151430785656,
    0.030123673379421234,
    -0.027867566794157028,
    -0.0754077136516571,
    0.060566581785678864,
    0.013262556865811348,
    -0.026328926905989647,
    -0.03273468092083931,
    0.0092179607599973679,
    -0.066641844809055328,
    -0.036649189889431,
    0.012274672277271748,
    0.013286147266626358,
    -0.027690675109624863,
    0.053847581148147583,
    0.031956706196069717,
    0.021002726629376411,
    0.070637710392475128,
    -0.020479680970311165,
    0.026211220771074295,
    -0.010783569887280464,
    0.079725094139575958,
    0.075771637260913849,
    0.060289330780506134,
    -0.028668681159615517,
    0.063761569559574127,
    -0.052471823990345,
    -0.070497497916221619,
    0.00862653087824583,
    0.026339350268244743,
    -0.017812449485063553,
    -0.038475185632705688,
    0.023601323366165161,
    0.020659279078245163,
    0.014828835614025593,
    0.0487472303211689,
    -0.0026578726246953011,
    -0.024867676198482513,
    -0.018363116309046745,
    0.039772097021341324,
    0.057799432426691055,
    0.011389456689357758,
    0.034263480454683304,
    0.043866187334060669,
    0.010009352117776871,
    -0.058985859155654907,
    0.0605064332485199,
    -0.018734430894255638,
    -0.012274564243853092,
    -0.0087205972522497177,
    -0.049622282385826111,
    0.012233071960508823,
    -0.024919500574469566,
    0.034494571387767792,
    0.10219443589448929,
    0.018306810408830643,
    0.0037214930634945631,
    0.0050488985143601894,
    0.032489504665136337,
    0.012311612255871296,
    0.0046417172998189926,
    0.014377428218722343,
    0.02847154438495636,
    0.011617257259786129,
    -0.00407814746722579,
    0.0036290527787059546,
    -0.026723280549049377,
    -0.0029446224216371775,
    0.015230421908199787,
    -0.010914525948464871,
    0.019561087712645531,
    0.022001221776008606,
    0.025866728276014328,
    -0.0039887246675789356,
    -0.055680666118860245,
    -0.011587056331336498,
    -0.042514923959970474,
    -0.029119288548827171,
    -0.012336518615484238,
    0.023060021921992302,
    -0.03457263857126236,
    -0.0313345305621624,
    -0.011379423551261425,
    -0.046389348804950714,
    -0.028168128803372383,
    0.01783706434071064,
    -0.042291246354579926,
    -0.032755132764577866,
    0.036293189972639084,
    0.054068837314844131,
    0.0027496430557221174,
    0.014791307970881462,
    0.0832904651761055,
    0.010443435981869698,
    -0.024064410477876663,
    -0.0066642207093536854,
    0.010516143403947353,
    0.080349594354629517,
    3.7701629480579868E-05,
    0.0087381200864911079,
    -0.0952531024813652,
    0.015727458521723747,
    0.063021592795848846,
    0.032641865313053131,
    -0.08632272481918335,
    0.059858653694391251,
    -0.030192382633686066,
    -0.012752462178468704,
    0.029174912720918655,
    0.0173934493213892,
    0.0050154696218669415,
    -0.0059035117737948894,
    -0.022883186116814613,
    -0.012473776005208492,
    0.00060590618522837758,
    0.060737475752830505,
    -0.051004581153392792,
    0.089415937662124634,
    0.029341204091906548,
    0.012817763723433018,
    -0.030467957258224487,
    0.055293191224336624,
    0.00071156956255435944,
    -0.0086140232160687447,
    -0.043749630451202393,
    0.010243786498904228,
    -0.0068933367729187012,
    -0.0782957375049591,
    -0.041873089969158173,
    0.020100099965929985,
    -0.03028329461812973,
    -0.03163350373506546,
    0.0027857122477144003,
    0.0020633216481655836,
    -0.009407559409737587,
    0.0069738710299134254,
    0.032772906124591827,
    -0.0037015152629464865,
    -0.052232936024665833,
    -0.038361407816410065,
    -0.053945928812026978,
    0.0077196331694722176,
    0.013588102534413338,
    -0.018648132681846619,
    -0.024372052401304245,
    -0.050423953682184219,
    0.024772915989160538,
    -0.035069085657596588,
    -0.0033589776139706373,
    0.0091087017208337784,
    -0.0087440125644207,
    -0.00824561808258295
  ],
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.