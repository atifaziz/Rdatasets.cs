Main website: https://vincentarelbundock.github.io/Rdatasets/

What is this?
=============

``Rdatasets`` is a collection of 1161 datasets that were originally distributed alongside the statistical software environment ``R`` and some of its add-on packages. The goal is to make these data more broadly accessible for teaching and statistical software development. 

What is included?
=================

The list of available datasets (csv and docs) is available here: 

+ `HTML index <http://vincentarelbundock.github.com/Rdatasets/datasets.html>`_
+ `CSV index <http://vincentarelbundock.github.com/Rdatasets/datasets.csv>`_

On the github repository you will also find: 

* ``Rdatasets.R``: ``R`` script to download CSV copies and HTML docs for all datasets distributed in ``Base R`` and a list of R packages. 

Adding data
===========

Many ``R`` packages ship with associated datasets, but the script included here only downloads data from packages that are installed locally on the machine where it is run. If you spot interesting data in a package distributed on CRAN, let me know. I will try to install that package on my computer and I will re-run the download script to see if the data can be added to this repository. Requests should be filed on the Github issue tracker.  

Omitted packages
================

Here are some packages that contain data but were not include in Rdatasets for one reason or another:

* CASdatasets: ``install.packages("CASdatasets", repos = "http://cas.uqam.ca/pub/R/")``
    - Some of the included datasets exceed the Github size limit.
    - Not on CRAN.

License
=======

The ``R`` documentation which I copied to the ``Rdatasets`` ``html`` folder is licensed under GPL. You will find a copy of the GPL in the ``license`` folder. I made a good faith effort to determine the license under which the actual data (i.e. rows/columns of numbers) were distributed, but I was unable to find a definitive answer. My understanding is that these datasets are free to re-distribute. However, if you own the rights to data that are included here and you object to their inclusion in ``Rdatasets``, send me an email at varel@umich.edu. I will promptly remove the data in question and will make sure that all traces are erased from the git revision history. 
 

