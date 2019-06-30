# ZombieApocalypse
<h4>Проект по Визуелно програмирање изработен од: Моника Димитрова, Христијан Манасијев</h4>
<hr> 
<br>
<p>
За тема на нашата проектна задача ние одбравме да направиме игра која ќе биде имплементирана со целосно наш код. “Zombie Apocalypse” e инспириранa од игри кои досега ги имаме играно и некои наши нови идеи.  Кога се стартува играта се појавува почетна форма која има неколку опции кои можат да се извршат. Има опции за да се започне нова игра, и уште една опција за откажување и затвoрање на самата игра. Играта не може да се започне доколку нема внесено име. Исто така на првата форма може да се види листата со најдобро постигнати резултати при што резултатот се запишува само доколку играчот победи во играта и неговиот резултат е во најдобрите 5.
</p>
<h4>
Изглед на почетната форма и поглед на најдобрите резултати:
</h4>
<h5>
  Опис на играта
  </h5>
 <p>
Играта “Zombie Apocalypse” е поделена на две нивоа. Првото ниво е полесното, и само доколку се помине, може да се игра второто односно потешкото. Целта на играта е играчот со својата муниција да уништи што повеќе zombies и да ги помине и двете нивоа. Само доколку ги помине двете нивоа неговиот резултат ќе може да се запише во листата со најдобри резулати. Муницијата на играчот е ограничена и потрошлива па тој може да ја зголеми само со ловење на подароци кои се појавувааат на одреден временски период. Во првото ниво играчот е нападнат од zombies кои доколку го допрат му одземаат мал дел од животот кој е прикажан со “progress bar”.  Играчот за да се спаси мора да ги уништи непријателите. Едно zombie е уништено само доколку биде погодено од еден куршум на играчот. По одреден број на уништени непријатели се појавува главното односно поголемото zombie. Тоа доколку го допре играчот, му одзема ¼ од животот. За разлика од другите zombies, големото zombie мора да прима 5 куршуми за да биде уништено. Со убивање на поголемото zombie, играчот го поминува првото ниво и оди на второто односно потешкото. Тежината на второто ниво е тоа што непријателите кои се појавуваат таму испуштаат смртоносна течност која доколку го погоди играчот му одзема поголем дел од животот. Исто така доколку го допрат му одзимаат дел од животот. Задачата на играчот е иста, да ги уништи непријателите. Во второто ниво исто се појавува поголемо zombie кое плука и доколку го погоди играчот или го допре, на играчот му останува многу мал дел од животот. Големото zombie од второто ниво се убива со 10 куршуми. По уништување на второто големо zombie играта завршува и резултат на играчот (бројот на уништени непријатели), доколку е во најдобрите 5, се запишува во листата на најдобри резултати.

  </p>
 <h5> Начин на играње</h5>
 <p>
Играта се игра со пет копчиња на тастатурата односно со копчињата UP, LEFT, RIGHT, DOWN, SPACE.  Со копчињата UP, LEFT, RIGHT, DOWN се движи играчот, а со копчето SPACE играчот пука во непријателите. 
Кога ќе се стартува нова игра, прво се појавува играчот и едно zombie кое се движи кон играчот со цел да го изеде. После неколку секунди се појавуваат по три непријатели. Непријателите продолжуваат да се појавуваат на одредено време по точно три. Играчот кој може да се движи треба да ги погоди овие непријатели со “bullet” што всушност е еден мал круг кој со притискање на копчето за пукање почнува да се исцртува од играчот па во насока на каде е свртен играчот во моментот на пукање.  Кога ќе стигне кругот до крајот на формата тој ичезнува и се брише од “bulletslist”, исто така кругот се брише и доколку допре до некое zombie, со тоа непријателот се уништува и се зголемува бројот на убиени непријатели за тој играч. Играчот има одреден број на “bullets” кои се дадени во левиот горен ќош. На одредено време се појавува подарок од муниција со кој играчот може да ја зголемува својата муниција.
  </p>
  <h5>
Изглед на играта:
</h5>
<p>
Непријателите се објекти од класите Zombie и Boss, тие се движат со константна брзина и се претставени со слика. Имаат насока на движење . Овие непријатели ако бидат допрени од куршум на играчот се уништуваат. Секогаш се движат кон играчот и ако го допрат му одземаат дел од животот. Ако подолго време играчот биде допрен од еден непријател може да му се одземе цел “живот”.  Постојат два вида на непријатели, разликата во нив е тоа што едните “плукаат” со што имаат поголеми шанси да го “убијат” играчот. Исто така разликата меѓу поголемите и помалите непријатели е колкав дел од животот на играчот му одземаат.
  </p>
  <p>
“Bullets” се куршумите со кои играчот ги уништува непријателите. Тие се објекти од класата Bullet имаат насока на движење, боја и позиција која се менува што означува дека куршумот се движи. Од истата класа се и “куршумите” на непријателите.
</p>
<p>
Најдобар резултат всушност е објект од класата HighScores  која ги содржи податочните структури List и Dictionary. Во листата се чуваат int вредности кои означуваат колку уништени непријатели има играчот додека во Dictionary се чува името и бројот на уништени непријатели. Најдобрите резултати се зачувуваат со помош на Serialization. 
</p>
<h5>Непријателите:</h5>
<p>За играчот се чуваат бројот на “животи” кои ако се потрошат се појавува Game Over прозорецот кој има две опции, да се почне нова игра односно да се врати на почетното мени или да се излезе од формата. Доколку играчот ги помине и двете нивоа добива известување и можност да ја види повторно табелата со најдобри резултати.</p>
<h5>GameOver Прозорецот и Winner прозорецот:</h5>
<p>
<h5>Опис на една од Класите (класата Hero):</h5>

Hero:<br>
Променливи од калсата:<br>
Класата содржи string Name – Името на играчот, <br>
int Health – Целобројна вредност на “животот” на играчот,<br>
Point Position – објект од класата Point од System.Drawing, ја означува позицијата на играчот,<br>
Image Image – слика за играчот,<br>
Direction Dir – Насока на играчот, Dir  е објект од енумерацијата Direction, може да биде UP, LEFT, RIGHT, DOWN,<br>
List<Bullet> Bullets – Листа од објекти од класата Bullet, тоа се всушност куршумите што ги пука играчот,<br>
Int Ammo – Целобројна вредност за муницијата на играчот<br>
Int Kills – бројот на уништени непријатели<br><br>
Конструкторот на класата: public Hero(int Width, int Height, string Name).  При креирањето на еден Hero потребни се висината и ширината на формата за да знае во кои граници смее играчот да се движи и исто така неговото име за да може подоцна да му се зачуваат резултатите. Класата Hero како и сите други класи има Draw метод каде што се исцртува играчот со помош на функцијата DrawImage od System.Drawing. Има три функции кои се однесуваат исцртување,  движење и бришење на куршумите од листата, тоа се MoveBullets(int width, int height), Shoot() и DrawBullets(Graphics g).  
Со функцијата Move(int Width, int Height, Direction Dir) се движи играчот во формата ограничен со ширината и висината. Со притискање на копчињата за движење на играчот му се дава насока со што во функцијата прво се проверува која насока е зададена, потоа се менува сликата на играчот за таа насока и накрај се придвижува за одередена вредност во таа насока доколку со придвижување играчот излегува од границите на формата, тој не се придвижува се додека не смени насока

</p>

