+-----+-----------------+
| epi | R Documentation |
+-----+-----------------+

Eysenck Personality Inventory (EPI) data for 3570 participants
--------------------------------------------------------------

Description
~~~~~~~~~~~

The EPI is and has been a very frequently administered personality test
with 57 measuring two broad dimensions, Extraversion-Introversion and
Stability-Neuroticism, with an additional Lie scale. Developed by
Eysenck and Eysenck, 1964. Eventually replaced with the EPQ which
measures three broad dimensions. This data set represents 3570
observations collected in the early 1990s at the Personality, Motivation
and Cognition lab at Northwestern. An additional data set (epiR) has
test and retest information for 474 participants. The data are included
here as demonstration of scale construction and test-retest reliability.

Usage
~~~~~

::

   data(epi)
   data(epi.dictionary)
   data(epiR)

Format
~~~~~~

A data frame with 3570 observations on the following 57 variables.

``id``
   The identification number within the study

``time``
   First (group testing) or 2nd time (before a lab experiment) for the
   epiR data set.

``study``
   Four lab based studies and their pretest data

``V1``
   a numeric vector

``V2``
   a numeric vector

``V3``
   a numeric vector

``V4``
   a numeric vector

``V5``
   a numeric vector

``V6``
   a numeric vector

``V7``
   a numeric vector

``V8``
   a numeric vector

``V9``
   a numeric vector

``V10``
   a numeric vector

``V11``
   a numeric vector

``V12``
   a numeric vector

``V13``
   a numeric vector

``V14``
   a numeric vector

``V15``
   a numeric vector

``V16``
   a numeric vector

``V17``
   a numeric vector

``V18``
   a numeric vector

``V19``
   a numeric vector

``V20``
   a numeric vector

``V21``
   a numeric vector

``V22``
   a numeric vector

``V23``
   a numeric vector

``V24``
   a numeric vector

``V25``
   a numeric vector

``V26``
   a numeric vector

``V27``
   a numeric vector

``V28``
   a numeric vector

``V29``
   a numeric vector

``V30``
   a numeric vector

``V31``
   a numeric vector

``V32``
   a numeric vector

``V33``
   a numeric vector

``V34``
   a numeric vector

``V35``
   a numeric vector

``V36``
   a numeric vector

``V37``
   a numeric vector

``V38``
   a numeric vector

``V39``
   a numeric vector

``V40``
   a numeric vector

``V41``
   a numeric vector

``V42``
   a numeric vector

``V43``
   a numeric vector

``V44``
   a numeric vector

``V45``
   a numeric vector

``V46``
   a numeric vector

``V47``
   a numeric vector

``V48``
   a numeric vector

``V49``
   a numeric vector

``V50``
   a numeric vector

``V51``
   a numeric vector

``V52``
   a numeric vector

``V53``
   a numeric vector

``V54``
   a numeric vector

``V55``
   a numeric vector

``V56``
   a numeric vector

``V57``
   a numeric vector

Details
~~~~~~~

The original data were collected in a group testing framework for
screening participants for subsequent studies. The participants were
enrolled in an introductory psychology class between Fall, 1991 and
Spring, 1995.

The structure of the E scale has been shown by Rocklin and Revelle
(1981) to have two subcomponents, Impulsivity and Sociability. These
were subsequently used by Revelle, Humphreys, Simon and Gilliland to
examine the relationship between personality, caffeine induced arousal,
and cognitive performance.

The epiR data include the original group testing data and matched data
for 474 participants collected several weeks later. This is useful for
showing that internal consistency estimates (e.g. ``alpha`` or
``omega``) can be low even though the test is stable across time. For
more demonstrations of the distinction between immediate internal
consistency and delayed test-retest reliability see the ``msqR`` and
``sai`` data sets and ``testRetest``.

Source
~~~~~~

Data from the PMC laboratory at Northwestern.

References
~~~~~~~~~~

Eysenck, H.J. and Eysenck, S. B.G. (1968). Manual for the Eysenck
Personality Inventory.Educational and Industrial Testing Service, San
Diego, CA.

Rocklin, T. and Revelle, W. (1981). The measurement of extraversion: A
comparison of the Eysenck Personality Inventory and the Eysenck
Personality Questionnaire. British Journal of Social Psychology,
20(4):279-284.

Examples
~~~~~~~~

::

   data(epi)
   epi.keys <- list(E = c("V1",  "V3",  "V8",  "V10", "V13", "V17", "V22", "V25", "V27", "V39",
     "V44", "V46", "V49", "V53", "V56", "-V5", "-V15", "-V20", "-V29", "-V32", "-V34","-V37",
      "-V41", "-V51"),
   N = c( "V2", "V4", "V7", "V9", "V11", "V14", "V16", "V19", "V21", "V23", "V26", "V28", 
   "V31", "V33", "V35", "V38", "V40","V43", "V45", "V47", "V50", "V52","V55", "V57"),
   L = c("V6",  "V24", "V36", "-V12", "-V18", "-V30", "-V42", "-V48", "-V54"),
   Imp = c( "V1",  "V3",  "V8",  "V10", "V13", "V22", "V39", "-V5", "-V41"),
   Soc = c( "V17", "V25", "V27", "V44", "V46", "V53", "-V11", "-V15", "-V20", 
   "-V29", "-V32", "-V37", "-V51")
   )
   scores <- scoreItems(epi.keys,epi)

   keys <- make.keys(epi,epi.keys)   #the old way of making keys is to make a matrix
   fa.lookup(keys[,1:3],epi.dictionary) #show the items and keying information

   #a variety of demonstrations (not run) of test retest reliability versus alpha versus omega

   E <- selectFromKeys(epi.keys$E)
   #omega(epi[E])  #to show the low omega but high alpha of Extraversion 
   #testRetest(epiR,select=E)  #test retest of the extraversion scale (.82) is higher than 
   #alpha  for either the first (.77) or second administration (.74)
   #Imp <- selectFromKeys(epi.keys$Imp)
   #testRetest(epiR,select=Imp)  #Similarly test retest = .68 but alpha = .48 and .50.
   #Soc <- selectFromKeys(epi.keys$Soc)
   #testRetest(epiR,select=Soc)  # test retest =.83, alpha = .76, .75
   #N <- selectFromKeys(epi.keys$N)
   #testRetest(epiR, select=N) #Test retest = .8, alpha = .81, .80
