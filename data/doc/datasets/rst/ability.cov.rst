+-------------+-----------------+
| ability.cov | R Documentation |
+-------------+-----------------+

Ability and Intelligence Tests
------------------------------

Description
~~~~~~~~~~~

Six tests were given to 112 individuals. The covariance matrix is given
in this object.

Usage
~~~~~

::

    ability.cov

Details
~~~~~~~

The tests are described as

general:
    a non-verbal measure of general intelligence using Cattell's
    culture-fair test.

picture:
    a picture-completion test

blocks:
    block design

maze:
    mazes

reading:
    reading comprehension

vocab:
    vocabulary

Bartholomew gives both covariance and correlation matrices, but these
are inconsistent. Neither are in the original paper.

Source
~~~~~~

Bartholomew, D. J. (1987) *Latent Variable Analysis and Factor
Analysis.* Griffin.

Bartholomew, D. J. and Knott, M. (1990) *Latent Variable Analysis and
Factor Analysis.* Second Edition, Arnold.

References
~~~~~~~~~~

Smith, G. A. and Stanley G. (1983) Clocking *g*: relating intelligence
and measures of timed performance. *Intelligence*, **7**, 353–368.

Examples
~~~~~~~~

::

    require(stats)
    (ability.FA <- factanal(factors = 1, covmat = ability.cov))
    update(ability.FA, factors = 2)
    ## The signs of factors and hence the signs of correlations are
    ## arbitrary with promax rotation.
    update(ability.FA, factors = 2, rotation = "promax")
