+------+-----------------+
| msqR | R Documentation |
+------+-----------------+

75 mood items from the Motivational State Questionnaire for 3032 unique participants
------------------------------------------------------------------------------------

Description
~~~~~~~~~~~

Emotions may be described either as discrete emotions or in dimensional
terms. The Motivational State Questionnaire (MSQ) was developed to study
emotions in laboratory and field settings. The data can be well
described in terms of a two dimensional solution of energy vs tiredness
and tension versus calmness. Additional items include what time of day
the data were collected and a few personality questionnaire scores. 3082
unique participants took the MSQ at least once, 2753 at least twice, 446
three times, and 181 four times. The 3032 also took the ``sai`` state
anxiety inventory at the same time.

Usage
~~~~~

::

    data("msqR")

Format
~~~~~~

A data frame with 6411 observations on the following 79 variables.

``active``
    a numeric vector

``afraid``
    a numeric vector

``alert``
    a numeric vector

``alone``
    a numeric vector

``angry``
    a numeric vector

``aroused``
    a numeric vector

``ashamed``
    a numeric vector

``astonished``
    a numeric vector

``at.ease``
    a numeric vector

``at.rest``
    a numeric vector

``attentive``
    a numeric vector

``blue``
    a numeric vector

``bored``
    a numeric vector

``calm``
    a numeric vector

``clutched.up``
    a numeric vector

``confident``
    a numeric vector

``content``
    a numeric vector

``delighted``
    a numeric vector

``depressed``
    a numeric vector

``determined``
    a numeric vector

``distressed``
    a numeric vector

``drowsy``
    a numeric vector

``dull``
    a numeric vector

``elated``
    a numeric vector

``energetic``
    a numeric vector

``enthusiastic``
    a numeric vector

``excited``
    a numeric vector

``fearful``
    a numeric vector

``frustrated``
    a numeric vector

``full.of.pep``
    a numeric vector

``gloomy``
    a numeric vector

``grouchy``
    a numeric vector

``guilty``
    a numeric vector

``happy``
    a numeric vector

``hostile``
    a numeric vector

``inspired``
    a numeric vector

``intense``
    a numeric vector

``interested``
    a numeric vector

``irritable``
    a numeric vector

``jittery``
    a numeric vector

``lively``
    a numeric vector

``lonely``
    a numeric vector

``nervous``
    a numeric vector

``placid``
    a numeric vector

``pleased``
    a numeric vector

``proud``
    a numeric vector

``quiescent``
    a numeric vector

``quiet``
    a numeric vector

``relaxed``
    a numeric vector

``sad``
    a numeric vector

``satisfied``
    a numeric vector

``scared``
    a numeric vector

``serene``
    a numeric vector

``sleepy``
    a numeric vector

``sluggish``
    a numeric vector

``sociable``
    a numeric vector

``sorry``
    a numeric vector

``still``
    a numeric vector

``strong``
    a numeric vector

``surprised``
    a numeric vector

``tense``
    a numeric vector

``tired``
    a numeric vector

``unhappy``
    a numeric vector

``upset``
    a numeric vector

``vigorous``
    a numeric vector

``wakeful``
    a numeric vector

``warmhearted``
    a numeric vector

``wide.awake``
    a numeric vector

``anxious``
    a numeric vector

``cheerful``
    a numeric vector

``idle``
    a numeric vector

``inactive``
    a numeric vector

``tranquil``
    a numeric vector

``kindly``
    a numeric vector

``scornful``
    a numeric vector

``time``
    a factor with levels ``1`` ``2`` ``3`` ``4``

``id``
    a numeric vector

``form``
    a numeric vector

``study``
    a character vector

Details
~~~~~~~

| The Motivational States Questionnaire (MSQ) is composed of 75 items,
  which represent the full affective space (Revelle & Anderson, 1998).
  The MSQ consists of 20 items taken from the Activation-Deactivation
  Adjective Check List (Thayer, 1986), 18 from the Positive and Negative
  Affect Schedule (PANAS, Watson, Clark, & Tellegen, 1988) along with
  the items used by Larsen and Diener (1992). The response format was a
  four-point scale that corresponds to Russell and Carroll's (1999)
  "ambiguous–likely-unipolar format" and that asks the respondents to
  indicate their current standing (“at this moment") with the following
  rating scale:
| 0—————-1—————-2—————-3
| Not at all A little Moderately Very much

The original version of the MSQ included 70 items. Intermediate analyses
(done with 1840 subjects) demonstrated a concentration of items in some
sections of the two dimensional space, and a paucity of items in others.
To begin correcting this, 3 items from redundantly measured sections
(alone, kindly, scornful) were removed, and 5 new ones (anxious,
cheerful, idle, inactive, and tranquil) were added. Thus, the
correlation matrix is missing the correlations between items anxious,
cheerful, idle, inactive, and tranquil with alone, kindly, and scornful.

1147 individuals took Form 1 version, 1885 the Form 2 version. To see
the relative frequencies by time and form, see the first example.

Procedure. The data were collected over nine years, as part of a series
of studies examining the effects of personality and situational factors
on motivational state and subsequent cognitive performance. In each of
38 studies, prior to any manipulation of motivational state,
participants signed a consent form and filled out the MSQ. (The
procedures of the individual studies are irrelevant to this data set and
could not affect the responses to the MSQ at time 1, since this
instrument was completed before any further instructions or tasks). Some
MSQ post test (after manipulations) is available in ``affect``.
Subsequent analysis of changes from time 1 to time 2, 3 and 4 is
underway and the experimental conditions codes will be merged in
eventually.

The EA and TA scales are from Thayer, the PA and NA scales are from
Watson et al. (1988). Scales and items:

Energetic Arousal: active, energetic, vigorous, wakeful, wide.awake,
full.of.pep, lively, -sleepy, -tired, - drowsy (ADACL)

Tense Arousal: Intense, Jittery, fearful, tense, clutched up, -quiet,
-still, - placid, - calm, -at rest (ADACL)

Positive Affect: active, alert, attentive, determined, enthusiastic,
excited, inspired, interested, proud, strong (PANAS)

Negative Affect: afraid, ashamed, distressed, guilty, hostile, irritable
, jittery, nervous, scared, upset (PANAS)

The PA and NA scales can in turn can be thought of as having subscales:
(See the PANAS-X) Fear: afraid, scared, nervous, jittery (not included
frightened, shaky) Hostility: angry, hostile, irritable, (not included:
scornful, disgusted, loathing guilt: ashamed, guilty, (not included:
blameworthy, angry at self, disgusted with self, dissatisfied with self)
sadness: alone, blue, lonely, sad, (not included: downhearted)
joviality: cheerful, delighted, energetic, enthusiastic, excited, happy,
lively, (not included: joyful) self-assurance: proud, strong, confident,
(not included: bold, daring, fearless ) attentiveness: alert, attentive,
determined (not included: concentrating)

The next set of circumplex scales were taken (I think) from Larsen and
Diener (1992). High activation: active, aroused, surprised, intense,
astonished Activated PA: elated, excited, enthusiastic, lively
Unactivated NA : calm, serene, relaxed, at rest, content, at ease PA:
happy, warmhearted, pleased, cheerful, delighted Low Activation: quiet,
inactive, idle, still, tranquil Unactivated PA: dull, bored, sluggish,
tired, drowsy NA: sad, blue, unhappy, gloomy, grouchy Activated NA:
jittery, anxious, nervous, fearful, distressed.

Keys for these separate scales are shown in the examples.

In addition to the MSQ, there are 5 scales from the Eysenck Personality
Inventory (Extraversion, Impulsivity, Sociability, Neuroticism, Lie).
The Imp and Soc are subsets of the the total extraversion scale.

Source
~~~~~~

Data collected at the Personality, Motivation, and Cognition Laboratory,
Northwestern University.

References
~~~~~~~~~~

Rafaeli, Eshkol and Revelle, William (2006), A premature consensus: Are
happiness and sadness truly opposite affects? Motivation and Emotion,
30, 1, 1-12.

Revelle, W. and Anderson, K.J. (1998) Personality, motivation and
cognitive performance: Final report to the Army Research Institute on
contract MDA 903-93-K-0008.
(https://www.personality-project.org/revelle/publications/ra.ari.98.pdf).

Thayer, R.E. (1989) The biopsychology of mood and arousal. Oxford
University Press. New York, NY.

Watson,D., Clark, L.A. and Tellegen, A. (1988) Development and
validation of brief measures of positive and negative affect: The PANAS
scales. Journal of Personality and Social Psychology, 54(6):1063-1070.

See Also
~~~~~~~~

``affect`` for an example of the use of some of these adjectives in a
mood manipulation study.

``make.keys``, ``scoreItems`` and ``scoreOverlap`` for instructions on
how to score multiple scales with and without item overlap. Also see
``fa`` and ``fa.extension`` for instructions on how to do factor
analyses or factor extension.

Given the temporal ordering of the ``sai`` data and the ``msqR`` data,
these data are useful for demonstrations of ``testRetest`` reliability.
See the examples in ``testRetest`` for how to combine the ``sai``
``tai`` and ``msqR`` datasets.

Examples
~~~~~~~~

::

    data(msqR)
    colSums(table(msqR$study,msqR$form,msqR$time))

    #score them for 20 short scales -- note that these have item overlap
    #The first 2 are from Thayer
    #The next 2 are classic positive and negative affect 
    #The next 9 are circumplex scales
    #the last 7 are msq estimates of PANASX scales (missing some items)
    keys.list <- list(
    EA = c("active", "energetic", "vigorous", "wakeful", "wide.awake", "full.of.pep",
           "lively", "-sleepy", "-tired", "-drowsy"),
    TA =c("intense", "jittery", "fearful", "tense", "clutched.up", "-quiet", "-still", 
           "-placid", "-calm", "-at.rest") ,
    PA =c("active", "excited", "strong", "inspired", "determined", "attentive", 
              "interested", "enthusiastic", "proud", "alert"),
    NAf =c("jittery", "nervous", "scared", "afraid", "guilty", "ashamed", "distressed",  
             "upset", "hostile", "irritable" ),
    HAct = c("active", "aroused", "surprised", "intense", "astonished"),
    aPA = c("elated", "excited", "enthusiastic", "lively"),
    uNA = c("calm", "serene", "relaxed", "at.rest", "content", "at.ease"),
    pa = c("happy", "warmhearted", "pleased", "cheerful", "delighted" ),
    LAct = c("quiet", "inactive", "idle", "still", "tranquil"),
    uPA =c( "dull", "bored", "sluggish", "tired", "drowsy"),
    naf = c( "sad", "blue", "unhappy", "gloomy", "grouchy"),
    aNA = c("jittery", "anxious", "nervous", "fearful", "distressed"),
    Fear = c("afraid" , "scared" , "nervous" , "jittery" ) ,
    Hostility = c("angry" ,  "hostile", "irritable", "scornful" ), 
    Guilt = c("guilty" , "ashamed" ),
    Sadness = c( "sad"  , "blue" , "lonely",  "alone" ),
    Joviality =c("happy","delighted", "cheerful", "excited", "enthusiastic", "lively", "energetic"), 
    Self.Assurance=c( "proud","strong" , "confident" , "-fearful" ),
    Attentiveness = c("alert" , "determined" , "attentive" ))

    #acquiscence = c("sleepy" ,  "wakeful" ,  "relaxed","tense")
       
           
    msq.scores <- scoreItems(keys.list,msqR)

    #show a circumplex structure for the non-overlapping items
    fcirc <- fa(msq.scores$scores[,5:12],2)  
    fa.plot(fcirc,labels=colnames(msq.scores$scores)[5:12])

    #now, find the correlations corrected for item overlap
    msq.overlap <- scoreOverlap(keys.list,msqR)
    f2 <- fa(msq.overlap$cor,2)
    fa.plot(f2,labels=colnames(msq.overlap$cor),title="2 dimensions of affect, corrected for overlap")
    if(FALSE) {
    #extend this solution to EA/TA  NA/PA space
    fe  <- fa.extension(cor(msq.scores$scores[,5:12],msq.scores$scores[,1:4]),fcirc)
    fa.diagram(fcirc,fe=fe,main="Extending the circumplex structure to  EA/TA and PA/NA ")

    #show the 2 dimensional structure
    f2 <- fa(msqR[1:72],2)
    fa.plot(f2,labels=colnames(msqR)[1:72],title="2 dimensions of affect at the item level")

    #sort them by polar coordinates
    round(polar(f2),2)

    #the msqR and sai data sets have 10 overlapping items which can be used for
    #testRetest analysis.  We need to specify the keys, and then choose the appropriate
    #data sets  
    sai.msq.keys <- list(pos =c( "at.ease" ,  "calm" , "confident", "content","relaxed"),
      neg = c("anxious", "jittery", "nervous" ,"tense"  ,   "upset"),
      anx = c("anxious", "jittery", "nervous" ,"tense", "upset","-at.ease" ,  "-calm" ,
      "-confident", "-content","-relaxed"))
    #select <- selectFromKeys(sai.msq.keys$anx)
    #The following is useful for examining test retest reliabilities
    #msq.control <- subset(msqR,msqR$study %in% c("Cart", "Fast", "SHED", "SHOP"))
    #msq.film <- subset(msqR,(msqR$study %in% c("FIAT","FLAT") & (msqR$time < 3) )) 
    #msq.film[((msq.film$study == "FLAT") & (msq.film$time ==3)) ,] <- NA 
    #msq.drug <- subset(msqR,(msqR$study %in% c("AGES",  "SALT", "VALE", "XRAY"))&(  msqR$time < 3))


    #msq.day <- subset(msqR,(msqR$study %in% c("SAM", "RIM")))




    }
