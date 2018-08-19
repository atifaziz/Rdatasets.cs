+--------------+-----------------+
| Harman23.cor | R Documentation |
+--------------+-----------------+

Harman Example 2.3
------------------

Description
~~~~~~~~~~~

A correlation matrix of eight physical measurements on 305 girls between
ages seven and seventeen.

Usage
~~~~~

::

    Harman23.cor

Source
~~~~~~

Harman, H. H. (1976) *Modern Factor Analysis*, Third Edition Revised,
University of Chicago Press, Table 2.3.

Examples
~~~~~~~~

::

    require(stats)
    (Harman23.FA <- factanal(factors = 1, covmat = Harman23.cor))
    for(factors in 2:4) print(update(Harman23.FA, factors = factors))
