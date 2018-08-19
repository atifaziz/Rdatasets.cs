+----------+-----------------+
| Indometh | R Documentation |
+----------+-----------------+

Pharmacokinetics of Indomethacin
--------------------------------

Description
~~~~~~~~~~~

The ``Indometh`` data frame has 66 rows and 3 columns of data on the
pharmacokinetics of indometacin (or, older spelling, ‘indomethacin’).

Usage
~~~~~

::

    Indometh

Format
~~~~~~

An object of class
``c("nfnGroupedData", "nfGroupedData", "groupedData", "data.frame")``
containing the following columns:

Subject
    an ordered factor with containing the subject codes. The ordering is
    according to increasing maximum response.

time
    a numeric vector of times at which blood samples were drawn (hr).

conc
    a numeric vector of plasma concentrations of indometacin (mcg/ml).

Details
~~~~~~~

Each of the six subjects were given an intravenous injection of
indometacin.

This dataset was originally part of package ``nlme``, and that has
methods (including for ``[``, ``as.data.frame``, ``plot`` and ``print``)
for its grouped-data classes.

Source
~~~~~~

Kwan, Breault, Umbenhauer, McMahon and Duggan (1976) Kinetics of
Indomethacin absorption, elimination, and enterohepatic circulation in
man. *Journal of Pharmacokinetics and Biopharmaceutics* **4**, 255–280.

Davidian, M. and Giltinan, D. M. (1995) *Nonlinear Models for Repeated
Measurement Data*, Chapman & Hall (section 5.2.4, p. 129)

Pinheiro, J. C. and Bates, D. M. (2000) *Mixed-effects Models in S and
S-PLUS*, Springer.

See Also
~~~~~~~~

``SSbiexp`` for models fitted to this dataset.
