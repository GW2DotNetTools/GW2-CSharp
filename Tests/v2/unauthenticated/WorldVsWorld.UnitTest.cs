using GW2CSharp;
using GW2CSharp.V2.Unauthenticated.WvW.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.V2.Unauthenticated
{
	[TestFixture]
	public class WorldVsWorld
	{
		[Test]
		public void ShouldReturnObjective()
		{
			var objective = GW2Api.V2.WvWObjectives.GetById("38-6");
			Assert.AreEqual("Speldan Clearcut", objective.Name);
			Assert.AreEqual(844, objective.SectorId);
			Assert.IsNotNull(objective.Coord);
			Assert.AreEqual(9841.05f, objective.Coord[0]);
			Assert.AreEqual(13545.8f, objective.Coord[1]);
			Assert.AreEqual(-508.295f, objective.Coord[2]);
		}

		[Test]
		public void ShouldReturnAllObjectives()
		{
			var objectives = GW2Api.V2.WvWObjectives.GetAll();
			Assert.IsNotNull(objectives);
			Assert.Greater(objectives.Count(), 0);
			var objective = objectives.First().Value;
			Assert.Greater(objective.Id, 0);
		}

		[Test]
		public void ShouldReturnMultipleObjectives()
		{
			var objectives = GW2Api.V2.WvWObjectives.GetMultiple("1102-100", "1143-100").ToList();

			Assert.AreEqual(2, objectives.Count);
		}

		[Test]
		public void ShouldReturnMatch()
		{
			var match = GW2Api.V2.WvWMatches.GetById("1-3");
			Assert.IsNotNull(match.Scores);
			Assert.IsNotNull(match.Worlds);
			Assert.IsNotNull(match.Deaths);
			Assert.IsNotNull(match.Kills);
			Assert.IsNotNull(match.Maps);
			Assert.Greater(match.Maps.Count, 0);
			Assert.IsNotNull(match.Maps[1].Type);
		}

		[Test]
		public void ShouldReturnMatchByWorld()
		{
			var match = GW2Api.V2.WvWMatches.GetByWorldId(1005);
			Assert.IsNotNull(match.Scores);
			Assert.IsNotNull(match.Worlds);
			Assert.IsNotNull(match.Deaths);
			Assert.IsNotNull(match.Kills);
			Assert.IsNotNull(match.Maps);
			Assert.IsNotNull(match.StartTime);
			Assert.IsNotNull(match.EndTime);
			Assert.Greater(match.Maps.Count, 0);

			var map = match.Maps[1];
			Assert.Greater(map.Id, 0);
			Assert.IsNotNull(map.Type);

			Assert.IsNotNull(map.Scores);
			var scores = map.Scores;
			Assert.Greater(scores.Red, 0);
			Assert.Greater(scores.Green, 0);
			Assert.Greater(scores.Blue, 0);

			Assert.IsNotNull(map.Bonuses);
			if (map.Bonuses != null && map.Bonuses.Count > 0)
			{
				var bonus = map.Bonuses.First();
				Assert.IsNotNullOrEmpty(bonus.Type);
				Assert.IsNotNull(bonus.Owner);
			}

			Assert.IsNotNull(map.Deaths);
			var deaths = map.Deaths;
			Assert.IsNotNull(deaths.Red);
			Assert.IsNotNull(deaths.Green);
			Assert.IsNotNull(deaths.Blue);

			Assert.IsNotNull(map.Kills);
			var kills = map.Kills;
			Assert.IsNotNull(kills.Red);
			Assert.IsNotNull(kills.Green);
			Assert.IsNotNull(kills.Blue);

			Assert.IsNotNull(map.Objectives);
			if (map.Bonuses != null)
			{
				var objective = map.Objectives.First();
				Assert.IsNotNullOrEmpty(objective.Id);
				Assert.IsNotNullOrEmpty(objective.Type);
				Assert.IsNotNull(objective.Owner);
				Assert.IsNotNull(objective.LastFlipped);
				if (objective.ClaimedBy != null)
				{
					Assert.IsNotEmpty(objective.ClaimedBy);
				}
				if (objective.ClaimedAt != null)
				{
					Assert.Greater(objective.ClaimedAt, new DateTime(0));
				}
			}
		}

		[Test]
		public void ShouldReturnAllMatches()
		{
			var matches = GW2Api.V2.WvWMatches.GetAll();
			Assert.IsNotNull(matches);
			Assert.Greater(matches.Count(), 0);
			var singleMatch = matches.First();
			Assert.IsNotNull(singleMatch.Value.Id);
		}

		[Test]
		public void ShouldReturnMultipleMatches()
		{
			var matches = GW2Api.V2.WvWMatches.GetMultipleById("1-8", "2-9").ToList();
			Assert.AreEqual(2, matches.Count);
		}
	}
}
