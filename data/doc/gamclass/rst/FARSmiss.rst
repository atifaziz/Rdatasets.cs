+----------+-----------------+
| FARSmiss | R Documentation |
+----------+-----------------+

Summary information on records omitted from the ``FARS`` dataset
----------------------------------------------------------------

Description
~~~~~~~~~~~

Data are a 3-way table, indexed by ``state``, a set of variable names,
and ``years``

Usage
~~~~~

::

   FARSmiss

Format
~~~~~~

The format is: num [1:51, 1:7, 1:13] 2 0 16 0 75 1 5 0 5 5 ... - attr(*,
"dimnames")=List of 3 ..$ : chr [1:51] "1" "2" "3" "4" ... ..$ : chr
[1:7] "injury" "age" "airbag" "restraint" ... ..$ : chr [1:13] "1998"
"1999" "2000" "2001" ...

Details
~~~~~~~

These data were generated using the function ``matchedPairs``, using as
input data downloaded from the URL given as source. Data for the years
2007 and 2008 are included with this package, and can be used to
generate the result of restricting ``FARS`` and ``FARSmiss`` to those
years. The check columns (all values should be zero) ``nomatch`` and
``dups`` have been omitted from the second dimension of the array

Source
~~~~~~

http://www-fars.nhtsa.dot.gov/Main/index.aspx

References
~~~~~~~~~~

http://maths-people.anu.edu.au/~johnm/nzsr/taws.html

See Also
~~~~~~~~

``matchedPairs``

Examples
~~~~~~~~

::

   data(FARSmiss)
   str(FARSmiss)
