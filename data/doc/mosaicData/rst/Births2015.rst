+------------+-----------------+
| Births2015 | R Documentation |
+------------+-----------------+

US Births in 2015
-----------------

Description
~~~~~~~~~~~

A day by day record of the number of births in the United States in
2015.

Usage
~~~~~

::

    data(Births2015)

Format
~~~~~~

A data frame with 365 observations on the following variables.

-  ``date`` date in 2015

-  ``births`` number of US births

-  ``dayofyear`` sequential number of days from 1 to 365

-  ``wday`` day of week as an ordered factor

Source
~~~~~~

Obtained from the National Center for Health Statistics, National Vital
Statistics System, Natality, 2015 data.

See Also
~~~~~~~~

``Births78``, ``Births``

Examples
~~~~~~~~

::

    data(Births2015)
    if (require(lattice)) {
      xyplot(births ~ date, Births2015)
      xyplot(births ~ date, Births2015, groups = wday)
    }
    if (require(dplyr)) {
      Births78 %>% 
        group_by(wday) %>% summarise(births = sum(births)) %>% 
        ungroup() %>% mutate(frac = births / sum(births))
      Births2015 %>% 
        group_by(wday) %>% summarise(births = sum(births)) %>% 
        ungroup() %>% mutate(frac = births / sum(births))
    }
