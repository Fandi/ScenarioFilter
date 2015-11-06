@filter:A
Feature: Feature

Scenario: Feature filtered by A
    Then this scenario should pass

@filter:B
Scenario: Scenario filtered by B
    Then this scenario should pass

@filter:C
@filter:B,A
Scenario: Scenario filtered by A, B, and C
    Then this scenario should pass

@filter:A,!B
Scenario: Scenario filtered by A and !B
    Then this negative scenario should be inconclusive

@filter:D
Scenario: Scenario filtered by D
    Then this negative scenario should be inconclusive

@filter:!E @custom
Scenario: Scenario filtered by !E and has a custom tag
    Then this scenario should pass
