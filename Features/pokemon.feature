Feature: PokeAPI Tests

  Scenario: Get Pokémon by ID
    Given I have a valid Pokémon ID
    When I request the Pokémon details
    Then the response status code should be 200
    And the response should contain the Pokémon name

  Scenario: Get Ability by ID
    Given I have a valid Ability ID
    When I request the Ability details
    Then the response status code should be 200
    And the response should contain the Ability name
