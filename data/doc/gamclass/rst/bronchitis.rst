+------------+-----------------+
| bronchitis | R Documentation |
+------------+-----------------+

Chronic bronchitis in a sample of men in Cardiff
------------------------------------------------

Description
~~~~~~~~~~~

The data consist of observations on three variables for each of 212 men
in a sample of Cardiff enumeration districts.

Usage
~~~~~

::

   bronchitis

Format
~~~~~~

A data.frame of 212 obs of 3 variables:

``cig``
   numeric, the number of cigarettes per day

``poll``
   numeric, the smoke level in the locality

``r``
   integer, 1= respondent suffered from chronic bronchitis

``rfac``
   factor, with levels ``abs`` (``r``\ =0), and ``abs`` (``r``\ =0)

Note
~~~~

See p.224 in SMIR

Source
~~~~~~

This copy of the dataset was copied from version 0.02 of the SMIR
package, which in turn obtained it from Jones (1975).

References
~~~~~~~~~~

Jones, K. (1975), *A geographical contribution to the aetiology of
chronic bronchitis*, Unpublished BSc dissertation, University of
Southampton. Published in Wrigley, N. (1976). *Introduction to the use
of logit models in geography*, Geo.Abstracts Ltd, CATMOG 10, University
of East Anglia, Norwich.

Murray Aitkin, Brian Francis, John Hinde and Ross Darnell (2009). SMIR:
Companion to Statistical Modelling in R (SMIR). Oxford University Press.

Examples
~~~~~~~~

::

   data(bronchit)
