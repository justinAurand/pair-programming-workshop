require "minitest/autorun"
require "bill_payer"

class TestBillPayer < Minitest::Test
  def setup
    @bill_payer = BillPayer.new
  end

  def test_example
    assert 1 == 1
  end
end