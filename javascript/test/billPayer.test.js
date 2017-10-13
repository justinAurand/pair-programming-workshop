const { expect } = require('chai');
const subject = require('../src/billPayer');

describe('billPayer', () => {
  it('should return hello world', () => {
    const result = subject();

    expect(result).to.equal('hello world');
  });
});
